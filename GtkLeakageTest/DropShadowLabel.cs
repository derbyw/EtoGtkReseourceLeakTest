using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;


namespace GtkLeakageTest
{
    public partial class DropShadowLabel
    {
        public DropShadowLabel() 
        {
            InitializeComponent();
        }

        public DropShadowLabel(DropShadownLabelVM M)
        {
            model = M;
            InitializeComponent();
        }

    }
}
