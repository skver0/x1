using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x1
{
    public partial class caps : Form
    {
        public caps()
        {
            InitializeComponent();
        }

        publicbool publicbool = new publicbool();
        private void caps_Load(object sender, EventArgs e)
        {
            TopMost = true;
            publicbool.visible = true;
            Opacity = 1;
            if (IsKeyLocked(Keys.CapsLock))
            {
                Opacity = 1;
                capsindicator.Text = "caps on"; 
            }
            else
            {
                Opacity = 1;
                capsindicator.Text = "caps off";
            }
            t1.Start();
            t1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.01;
            }
            else {
                publicbool.visible = false;
                Close();
                t1.Stop();
            }
        }
    }
}
