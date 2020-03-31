using eDrawingHostControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edrawing_TEST
{
    public partial class Form1 : Form
    {
        eDrawingHostControl.eDrawingControl ctrl = null;
        public Form1()
        {
            InitializeComponent();

            if (null == ctrl)
            {
                ctrl = new eDrawingControl();
            }
            this.Controls.Add(ctrl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ctrl != null)
            {
                pictureBox1.Visible = false;
                //ctrl.Location = new Point(0, 0);
                //ctrl.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height);
                ctrl.Location = pictureBox1.Location;
                ctrl.Size = pictureBox1.Size;
                ctrl.eDrawingControlWrapper.OpenDoc(@"C:\Users\HP\Desktop\DMS TEST File\4040 Profile.sldprt", false, false, false, "");
            }
        }
    }
}
