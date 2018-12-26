using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace x1
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //tfw you are too lazy to code a left sided bar
            try
            {
                if (checkBox1.Checked)
                {
                    if (!checkBox2.Checked)
                        File.Create(appdata + "/x1left");
                }
                else
                {
                    if (!checkBox2.Checked)
                        File.Delete(appdata + "/x1left");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Help_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(appdata + "/x1left"))
                {
                        checkBox1.Checked = true;
                }

                if (File.Exists(appdata + "/x1top"))
                {
                    checkBox2.Checked = true;
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked)
                {
                    if (!checkBox1.Checked)
                    File.Create(appdata + "/x1top");
                }
                else
                {
                    if (!checkBox1.Checked)
                    File.Delete(appdata + "/x1top");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(appdata + "/x1custom")) {
                File.Delete(appdata + "/x1custom");
                using (StreamWriter storedata = File.CreateText(appdata + "/x1custom"))
                {
                    storedata.WriteLine(textBox1.Text);
                }
            } else {
                using (StreamWriter storedata = File.CreateText(appdata + "/x1custom"))
                {
                    storedata.WriteLine(textBox1.Text);
                }
            }
        }
    }
}
