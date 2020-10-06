using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace GtkLeakageTest
{
    public class PlainVerticalBarVM : BindableBase
    {


        public PlainVerticalBarVM()
        {
            myMin = 0;
            myMax = 100;
            myValue = 75;
            Visible = true;
            myDataFadeColor = "Colors.Black";
			myDataColor = "Colors.Red";
			myBoxBorderTopLeft = "Colors.WhiteSmoke";
			myBoxBorderBottomRight = "Colors.DarkGray";
			myBarBackColor = "Colors.DimGray";
            mToolTip = "";
        }

        private int mSlot;
        public int Slot
        {
            get { return mSlot+1; }
            set { SetProperty(ref mSlot, value-1); }
        }

        private double myMax;
        public double Max
        {
            get { return myMax; }
            set { SetProperty(ref myMax, value); }
        }

        private double myMin;
        public double Min
        {
            get { return myMin; }
            set { SetProperty(ref myMin, value); }
        }

        private double myValue;
        public double Value
        {
            get { return myValue; }
            set { SetProperty(ref myValue, value); }
        }

		private string myDataColor;        
		public string DataColor
        {
            get { return myDataColor; }
            set { SetProperty(ref myDataColor, value); }
        }

		private string myDataFadeColor;
		public string DataFadeColor
        {
            get { return myDataFadeColor; }
            set { SetProperty(ref myDataFadeColor, value); }
        }
		private string myBoxBorderTopLeft;
		public string BoxBorderTopLeft
        {
            get { return myBoxBorderTopLeft; }
            set { SetProperty(ref myBoxBorderTopLeft, value); }
        }
		private string myBoxBorderBottomRight;
		public string BoxBorderBottomRight
        {
            get { return myBoxBorderBottomRight; }
            set { SetProperty(ref myBoxBorderBottomRight, value); }
        }

		private string myBarBackColor;
		public string BarBackColor
        {
            get { return myBarBackColor; }
            set { SetProperty(ref myBarBackColor, value); }
        }
        

        private bool mVisible;
        public bool Visible
        {
            get { return mVisible; }
            set { SetProperty(ref mVisible, value); }            
        }

        private string mToolTip;
        public string ToolTip
        {
            get { return mToolTip; }
            set { SetProperty(ref mToolTip, value); }
        }

        /// <summary>
        /// Remote link simplifies the display so it works better on
        /// remote connections..
        /// </summary>
        private bool mRemoteLink;
        public bool RemoteLink
        {
            get { return mRemoteLink; }
            set { SetProperty(ref mRemoteLink, value); }
        }


        // Refresh gauge with the current data for it's slot
        public void Refresh(float[] slot_data)
        {
            if ((mSlot > 0) && (mSlot < slot_data.Length)) 
                Value = slot_data[mSlot];
			else
				Value = 0.0;
        }
    }
}
