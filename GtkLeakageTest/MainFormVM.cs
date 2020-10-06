using System.Threading;
using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace GtkLeakageTest
{
    class MainFormVM
    {
        private const int info_count = 16;

        public DropShadownLabelVM[] Labels;

        public PlainVerticalBarVM LeftBar;
        public PlainVerticalBarVM MiddleBar;
        public PlainVerticalBarVM RightBar;

        public PlainVerticalBarVM Pump;


        private readonly object stateGuard = new object();

        public bool enable_update  { get; private set;  }
        private CancellationTokenSource cts;

        public MainFormVM()
        {
            enable_update = true;
            Labels = new DropShadownLabelVM[info_count];
            for(int i = 0; i < Labels.Length; i++)
            {
                Labels[i] = new DropShadownLabelVM();
                Labels[i].Text = "N/A";
            }

            LeftBar = new PlainVerticalBarVM();
            MiddleBar = new PlainVerticalBarVM();
            RightBar = new PlainVerticalBarVM();

            Pump = new PlainVerticalBarVM();


            Pump.Min = 0;
            Pump.Max = 4096;
            Pump.Value = 0;

            LeftBar.Min = 0;
            LeftBar.Max = 900;
            LeftBar.Value = 0;

            MiddleBar.Min = 0;
            MiddleBar.Max = 400;
            MiddleBar.Value = 0;

            RightBar.Min = 0;
            RightBar.Max = 400;
            RightBar.Value = 0;

        }





        /// <summary>
        /// Simulates data coming in from the system - driving the display from non UI thread...
        /// </summary>
        public Task StartData(CancellationToken ct)        
        {
            return Task.Factory.StartNew(() =>
            {
                var current = new string[info_count];
                var barvals = new double[3];
                var r = new Random(0x3456);                
                bool run = true;
                int ramp = 0;
                int rampdir = 1;
                int step = 2;

                do
                {
                    // simulate the data sources...
                    for (int i = 0; i < current.Length; i++)
                    {
                        current[i] = (r.NextDouble() * 500.0).ToString("###.00"); 
                    }

                    ramp += step * rampdir;
                    if (ramp < Pump.Min) { rampdir = 1; ramp = (int)Pump.Min; }
                    if (ramp > Pump.Max) { rampdir = -1; ramp = (int)Pump.Max; }

                    barvals[0] = r.NextDouble() * LeftBar.Max;
                    barvals[1] = r.NextDouble() * MiddleBar.Max;
                    barvals[2] = r.NextDouble() * RightBar.Max;

                    if (enable_update)                    
                    {
                        // still async - make sure only we have access..
                        using (stateGuard.Lock(TimeSpan.FromMilliseconds(100)))
                        {
                            for (int i = 0; i < Labels.Length; i++)
                            {                                
                                Labels[i].Text = current[i];
                            }
                            LeftBar.Value = barvals[0];
                            MiddleBar.Value = barvals[1];
                            RightBar.Value = barvals[2];
                            Pump.Value = ramp;
                        }
                    }
                    
                    if (ct.IsCancellationRequested) run = false;

                    Thread.Sleep(100);
                } while (run);
            }, ct);
        }

        /// <summary>
        /// let task run but suspend updates..
        /// </summary>
        /// <remarks>to verify background task activity is memory neutral</remarks>
        public void PauseUpdate()
        {
            using (stateGuard.Lock(TimeSpan.FromMilliseconds(5)))
            {
                enable_update = !enable_update;
            }
        }

        /// <summary>
        /// Start/Cancel the background update task
        /// </summary>
        public async void ToggleUpdate()
        {

            if (cts == null) {
                cts = new CancellationTokenSource();
                await StartData(cts.Token);
                cts = null;
            } else
            {
                cts.Cancel();
            }
        }
    }
}
