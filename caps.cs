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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void caps_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;
            if (IsKeyLocked(Keys.CapsLock))
            {
                label1.Text = "A";
            }
            else
            {
                label1.Text = "a";
            }
            timer1.Start();
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.01;
            }
            else {
                this.Close();
                timer1.Stop();
            }
        }
    }
}
