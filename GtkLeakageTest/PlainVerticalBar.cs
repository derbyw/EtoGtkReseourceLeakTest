using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;

namespace GtkLeakageTest
{
    public partial class PlainVerticalBar
    {
        public PlainVerticalBar()
        {
            InitializeComponent();
        }

        
        public PlainVerticalBar(PlainVerticalBarVM M)
        {
            model = M;
            InitializeComponent();
        }
        
    }
}
