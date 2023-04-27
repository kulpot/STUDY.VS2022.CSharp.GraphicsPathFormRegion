using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPathFormRegion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetRegion();
        }

        private void SetRegion()
        {
            var GP = RoundedRectangle.RoundedRect(this.ClientRectangle, 10);
            //var GP = RoundedRectangle.Create(this.ClientRectangle, 20);
            this.Region = new Region(GP);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetRegion();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.Width += 1;
        }
    }
}
