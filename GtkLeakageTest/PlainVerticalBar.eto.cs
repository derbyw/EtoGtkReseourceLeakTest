#define Drawable
using System;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using Eto.Forms;
using Eto.Drawing;



namespace GtkLeakageTest
{
	partial class PlainVerticalBar : AiiPanelBase
    {
        
        protected PlainVerticalBarVM model;
        
        private double scaling;
        private Rectangle DataBar;

        SolidBrush FillBrush;
		SolidBrush BarBackBrush;
		Pen TopLeftPen;
		Pen BottomRightPen;

		private LinearGradientBrush DataBrush;
		private int resource_count;

        private int brush_width;

        private bool disposed = false;
        private bool sized = false;

        private bool use_creategraphics;

        public bool suppress_invalidate { get; set; }

#if Drawable
        private Drawable GraphBox;
#else   
        private const int pbarrange = 1000;
        private ProgressBar GraphBar;
#endif

        private readonly object stateGuard = new object ();

        void InitializeComponent()
        {
            if (model == null) model = new PlainVerticalBarVM();

            suppress_invalidate = false;

            Size = new Size(20, 133);

            mRemote = false;

            model.Min = 0.0;
			model.Max = 100.0;
			model.Value = 75.0;

			model.PropertyChanged += Model_PropertyChanged;
            

			mBarBackColor = Colors.Black; 
			mDataFadeColor = Color.FromRgb(0x400000);
			mDataColor = Colors.Red;
            mBoxBorderTopLeft = Colors.WhiteSmoke;
            mBoxBorderBottomRight = Colors.DarkGray;

			BarBackBrush = new SolidBrush (mBarBackColor);
			TopLeftPen = new Pen(mBoxBorderTopLeft);
			BottomRightPen = new Pen (mBoxBorderBottomRight);

            
            FillBrush = new SolidBrush(mDataColor);                  

            resource_count = 0;
            brush_width = int.MinValue;

#if Drawable
            GraphBox = new Drawable();
            GraphBox.Paint += GraphBox_Paint;
            GraphBox.SizeChanged += GraphBox_SizeChanged;
            use_creategraphics = GraphBox.SupportsCreateGraphics;

            Content = GraphBox;
#else
            GraphBar = new ProgressBar();
            GraphBar.SizeChanged += GraphBox_SizeChanged;
            GraphBar.MinValue = 0;
            GraphBar.MaxValue = pbarrange;
            GraphBar.Value = 0;
            GraphBar.Style = "vertical_bar";
            

            Content = GraphBar;
#endif



            DataBrush = null;
            CalculateScaling();
        }


        void Model_PropertyChanged (object sender, PropertyChangedEventArgs e)
        {
            using (stateGuard.Lock(TimeSpan.FromMilliseconds(100)))
            {
                switch (e.PropertyName)
                {
                    case "Value":
                        CalculateBox();
                        break;
                }
            }
            Application.Instance.AsyncInvoke(DataUpdated);
        }

        /// <summary>
        /// invalidates the control, causing a 
        /// </summary>
        private void DataUpdated()
        {
#if Drawable
            if (! suppress_invalidate) GraphBox.Invalidate();

#else
            if (! suppress_invalidate) GraphBar.Invalidate();
#endif
        }

#if Drawable
        void DrawWithCreateGraphics()
		{

			using (var graphics = GraphBox.CreateGraphics())
			{
				DrawBar(graphics);				
			}
		}
#endif

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Release managed resources.  
                    DataBrush.Dispose();
                }
                // Release unmanaged resources.
                // Set large fields to null.
                // Call Dispose on the base class.                
                DataBrush = null;
                disposed = true;
            }            
            base.Dispose(disposing);
        }


        private Color mDataColor;
        /// <summary>
        /// Sets the color of the graph data
        /// </summary>
        public Color DataColor
        {
            get
            {
                return (mDataColor);
            }

            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					mDataColor = value;                
					SizeBrush ();
				}
            }
        }


        private Color mDataFadeColor;
        /// <summary>
        /// Sets the color of the graph data
        /// </summary>
        public Color DataFadeColor
        {
            get
            {
                return (mDataFadeColor);
            }

            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					mDataFadeColor = value;
					SizeBrush ();
				}
            }
        }

        private Color mBoxBorderTopLeft;
        /// <summary>
        /// Sets the outline border color ("lit" sides)
        /// </summary>
        public Color BoxBorderTopLeft
        {
            get
            {
                return (mBoxBorderTopLeft);
            }

            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					mBoxBorderTopLeft = value;
					TopLeftPen.Dispose ();
					TopLeftPen = new Pen(mBoxBorderTopLeft);

				}
                
            }
        }


        private Color mBoxBorderBottomRight;
        /// <summary>
        /// Sets the outline border color ("lit" sides)
        /// </summary>
        public Color BoxBorderBottomRight
        {
            get
            {
                return (mBoxBorderBottomRight);
            }

            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					mBoxBorderBottomRight = value;    
					BottomRightPen.Dispose();
					BottomRightPen = new Pen (mBoxBorderBottomRight);
				}
            }
        }

		// define gradient transform...
		private float OffsetX = 0;
		private float OffsetY = 0;
		private float ScaleX = 100;
		private float ScaleY = 100;
		private float Rotation = 90;

		private IMatrix GetTransform()
		{
			var matrix = Matrix.Create();
			matrix.Translate(OffsetX, OffsetY);
			matrix.Scale(Math.Max(ScaleX / 100f, 0.01f), Math.Max(ScaleY / 100f, 0.01f));
			matrix.Rotate(Rotation);
			return matrix;
		}


        /// <summary>
        /// creates the linear gradient for nice looking controls
        /// </summary>
        private void SizeBrush()
        {
            
			if (FillBrush != null) {
				FillBrush.Dispose ();
				FillBrush = null;
			}
            FillBrush = new SolidBrush(mDataColor);

            //Console.WriteLine("On brush resize Control {0}  Box {1}", Width, GraphBox.Bounds.Width);

			int new_size = (Width) / 2;            
            if (new_size < 10) new_size = 10;
            PointF start = new PointF(0, 0);
			PointF stop = new PointF(0, new_size);            

			if (DataBrush != null) {
				DataBrush.Dispose ();
				DataBrush = null;
			}
			DataBrush = new LinearGradientBrush(DataFadeColor, DataColor, start, stop)
			{
				Wrap = GradientWrapMode.Reflect,
				Transform = GetTransform(),
			};
            brush_width = new_size;  
            resource_count++;
                      
        }


        private Color mBarBackColor;
        /// <summary>
        /// Sets the bar graph background color
        /// </summary>
        public Color BarBackColor
        {
            get
            {
                return (mBarBackColor);
            }
            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					mBarBackColor = value;
					BarBackBrush.Dispose ();
					BarBackBrush = new SolidBrush (mBarBackColor);
				}
            }
        }

        private bool mRemote;
        /// <summary>
        /// Sets the bar graph background color
        /// </summary>
        public bool Remote
        {
            get
            {
                return (mRemote);
            }
            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					mRemote = value;
				}
            }
        }


        /// <summary>
        /// This needs to be called on Min/Max and height changes
        /// </summary>
        private void CalculateScaling()
        {

			double range = (model.Max - model.Min);
            if (range == 0.0)
            {
                range = 1.0;
            }

            scaling = Height / range;	
            CalculateBox();

        }

        private void CalculateBox()
        {
            double range = Max - Min;
            double span = Data - Min;

            // convert range to pixels
			double offset = span * scaling;
            double percent = span / range;

            // clip as necessary...
            if (offset < 0) offset = 0;
            if (offset > Height) offset = Height;

            DataBar = new Rectangle(1,
                                    Height - (int)offset,
                                    Width - 1,
                                    Height);
#if Drawable
#else
            GraphBar.Value = (int)(1000 * percent);
#endif
        }


        /// <summary>
        ///  support update the data from the UI/View side ...
        /// </summary>
        /// <remarks>
        /// These can be async...
        /// </remarks>
        //private double mData;
        public double Data
        {
            get
            {
				return (model.Value);
            }
            set
            {
                model.Value = value;
            }
        }

        
        public double Min
        {
            get
            {
                return (model.Min);
            }
            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					model.Min = value;
					CalculateScaling ();
				}
            }
        }
		        
        public double Max
        {
            get
            {
				return (model.Max);
            }
            set
            {
				using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
					model.Max = value;
					CalculateScaling ();
				}
            }
        }

        



        public void SetRange(double min, double max)
        {
			using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
				model.Min = min;
				model.Max = max;
				CalculateScaling ();
			}
        }

#if Drawable
        /// <summary>
        /// Draws an rectangle with colors on the top/left and bottom/right with the given <paramref name="width"/>
        /// </summary>
        /// <param name="topLeftColor">Color for top/left edges</param>
        /// <param name="bottomRightColor">Color for bottom/right edges</param>
        /// <param name="rectangle">Outside of inset rectangle to draw</param>
        /// <param name="width">Width of the rectangle, in pixels</param>
        public void DrawInsetRectangle(Graphics g, RectangleF rectangle, int width = 1)
		{		
			for (int i = 0; i < width; i++)
			{
				g.DrawLine(TopLeftPen, rectangle.TopLeft, rectangle.InnerTopRight);
				g.DrawLine(TopLeftPen, rectangle.TopLeft, rectangle.InnerBottomLeft);
				g.DrawLine(BottomRightPen, rectangle.InnerBottomLeft, rectangle.InnerBottomRight);
				g.DrawLine(BottomRightPen, rectangle.InnerTopRight, rectangle.InnerBottomRight);
				rectangle.Inflate(-1, -1);
			}
		}

        public void DrawBar(Graphics g)
        {
			using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
				try {

					g.Clear (BarBackBrush);
					if (sized) {
						if ((mRemote) || (DataBrush == null)) {
							g.FillRectangle (FillBrush, DataBar);
						} else {
							g.FillRectangle (DataBrush, DataBar);
						}
						// use faster local one - avoids pen allocations..
						DrawInsetRectangle (g, GraphBox.Bounds, 2);
					}
				} catch (System.Exception grapherr) {
					Console.WriteLine ("Draw Plain Vert Bar. : " + grapherr.Message);
				}
			}
        }
#endif

        private void GraphBox_SizeChanged(object sender, EventArgs e)
        {
            sized = true;
			using (stateGuard.Lock (TimeSpan.FromMilliseconds (100))) {
				SizeBrush ();
				CalculateScaling ();        
			}
        }

#if Drawable
		// called to paint the contents of the box
		private void GraphBox_Paint(object sender, PaintEventArgs e)
		{
            if (Visible)
            {
                if (use_creategraphics)
                    DrawWithCreateGraphics();
                else
                    DrawBar(e.Graphics);
            }
		}
#endif

    }
}


