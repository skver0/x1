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

              if (File.Exists(appdata + "/x1offset"))
            {
                using (StreamReader readdata = File.OpenText(appdata + "/x1offset"))
                {
                    numericUpDown1.Value = Convert.ToDecimal(readdata.ReadLine());
                }
            }
            if (File.Exists(appdata + "/x1left"))
                {
                        checkBox1.Checked = true;
                }

                if (File.Exists(appdata + "/x1top"))
                {
                    checkBox2.Checked = true;
                }
                
                if (File.Exists(appdata + "/x12nd"))
                {
                    checkBox3.Checked = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            colorselect.ShowDialog();
            colorpicker.BackColor = colorselect.Color;
            if (File.Exists(appdata + "/x1color"))
            {
                File.Delete(appdata + "/x1color");
                using (StreamWriter storedata = File.CreateText(appdata + "/x1color"))
                {
                    storedata.WriteLine(colorselect.Color.ToArgb().ToString());
                }
            }
            else
            {
                using (StreamWriter storedata = File.CreateText(appdata + "/x1color"))
                {
                    storedata.WriteLine(colorselect.Color.ToArgb().ToString());
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            opcatiyindicator.Text = setopacity.Value.ToString() + "% Opacity";
            if (File.Exists(appdata + "/x1opacity"))
            {
                File.Delete(appdata + "/x1opacity");
                using (StreamWriter storedata = File.CreateText(appdata + "/x1opacity"))
                {
                    storedata.WriteLine(setopacity.Value.ToString());
                }
            }
            else
            {
                using (StreamWriter storedata = File.CreateText(appdata + "/x1opacity"))
                {
                    storedata.WriteLine(setopacity.Value.ToString());
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                File.Create(appdata + "/x12nd");
            }
            else
            {
                File.Delete(appdata + "/x12nd");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (File.Exists(appdata + "/x1offset"))
            {
                File.Delete(appdata + "/x1offset");
                using (StreamWriter storedata = File.CreateText(appdata + "/x1offset"))
                {
                    storedata.WriteLine(numericUpDown1.Value);
                }
            }
            else
            {
                using (StreamWriter storedata = File.CreateText(appdata + "/x1offset"))
                {
                    storedata.WriteLine(numericUpDown1.Value);
                }
            }
        }
    }
    }
