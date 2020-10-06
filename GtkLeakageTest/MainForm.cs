using System;
using System.Diagnostics;
using Eto.Forms;
using Eto.Drawing;
using System.Threading;
using System.Resources;

namespace GtkLeakageTest
{
    public partial class MainForm : Form
    {
        private const int LabelHeight = 25;

        private MainFormVM model;

        private Timer mem_update;

        private Label meminfo;

        private DropShadowLabel[] Labels;

        public MainForm()
        {
            model = new MainFormVM();

            DataContext = model;

            
            Title = "Gtk Leak Test App";
            ClientSize = new Size(1200, 700);
            var newfont = new Font(FontFamilies.SansFamilyName, 12);

            Labels = new DropShadowLabel[16];
            for(int i = 0; i < Labels.Length; i++)
            {
                Labels[i] = new DropShadowLabel(model.Labels[i]);
                Labels[i].Font = newfont;
                Labels[i].TextAlign = ContentAlignment.MiddleCenter;
                Labels[i].Size = new Size(56, LabelHeight);
            }


            var LeftBar = new PlainVerticalBar(model.LeftBar);
            LeftBar.Size = new Size(71, 224);

            var MiddleBar = new PlainVerticalBar(model.MiddleBar);
            MiddleBar.Size = new Size(71, 224);

            var RightBar = new PlainVerticalBar(model.RightBar);
            RightBar.Size = new Size(71, 224);

            var Pump = new PlainVerticalBar(model.Pump);
            Pump.Size = new Size(71, 224);

            // for GC/Process memory
            meminfo = new Label { Font = newfont, TextColor = Colors.White };
                       

            var displayarea = new TableLayout
            {
                BackgroundColor = Colors.DarkBlue,
                Spacing = new Size(2, 2),
                Rows =
                {
                    new TableRow
                    {
                        ScaleHeight = true,
                        Cells = {
                            new TableCell(Labels[0],true),
                            new TableCell(Labels[1],true),
                            new TableCell(Labels[2],true),
                            new TableCell(Labels[3],true),
                        }
                    },
                    new TableRow
                    {
                        ScaleHeight = true,
                        Cells = {
                            new TableCell(Labels[4],true),
                            new TableCell(Labels[5],true),
                            new TableCell(Labels[6],true),
                            new TableCell(Labels[7],true),
                        }
                    },
                    new TableRow
                    {
                        ScaleHeight = true,
                        Cells = {
                            new TableCell(Labels[8],true),
                            new TableCell(Labels[9],true),
                            new TableCell(Labels[10],true),
                            new TableCell(Labels[11],true),
                        }
                    },
                    new TableRow
                    {
                        ScaleHeight = true,
                        Cells = {
                            new TableCell(Labels[12],true),
                            new TableCell(Labels[13],true),
                            new TableCell(Labels[14],true),
                            new TableCell(Labels[15],true),
                        }
                    },
                    new TableRow
                    {
                        ScaleHeight = false,
                        Cells = {
                            new TableCell(LeftBar,false),
                            new TableCell(MiddleBar,false),
                            new TableCell(RightBar,false),
                            new TableCell(Pump,false),
                        }
                    },
                }
            };



            Content = new TableLayout
            {
                BackgroundColor = Colors.RoyalBlue,
                //Size = new Size(ClientSize.Width - 1, 20),
                Spacing = new Size(2, 2),
                Rows =
                {
                    displayarea,
                    meminfo
                }

            };                

            // create a few commands that can be used for the menu and toolbar
            var startstop = new Command { MenuText = "Start/Stop", ToolBarText = "Start/Stop" };
            startstop.Executed += (sender, e) => model.ToggleUpdate();

            var pause = new Command { MenuText = "Toggle Update", ToolBarText = "Toggle Update" };
            pause.Executed += (sender, e) => model.PauseUpdate();

            // create toolbar			
            ToolBar = new ToolBar { Items = { startstop, pause } };

            GetInitialMemory();

            mem_update = new Timer(UpdateMemField, null, 0, 2000);            
        }

        /// <summary>
        /// Async timer - probably not on UI thread...
        /// </summary>
        /// <param name="state"></param>
        private void UpdateMemField(object state)
        {
            // reroute to UI thread...
            Application.Instance.AsyncInvoke(UpdateMemDisplay);            
        }

        private void UpdateMemDisplay()
        {
            string info = ShowMemory();
            if (model.enable_update)
            {
                meminfo.Text = info;
            }
        }


        private long start_total;
        private long start_private;

        private void GetInitialMemory()
        {
            Process ThisProcess = Process.GetCurrentProcess();
            start_total = GC.GetTotalMemory(true);
            start_private= ThisProcess.PrivateMemorySize64;
        }


        private string ShowMemory()
        {
            Process ThisProcess = Process.GetCurrentProcess();
            long end_total = GC.GetTotalMemory(true);
            long diff = end_total - start_total;
            long pend = ThisProcess.PrivateMemorySize64;
            long pdiff = pend - start_private;

            var result = string.Format(" GC Memory : change {0:n} Total {1:n} Process change {2:n} - Total {3:n}", diff, end_total, pdiff, pend);

            Console.WriteLine(result);

            return result;
        }
    }

}
