namespace x1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.nt1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_Media = new System.Windows.Forms.Panel();
            this.p_Forward = new System.Windows.Forms.PictureBox();
            this.p_Back = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.p_Media.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_Forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Interval = 70;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Consolas", 13F);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(1848, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(60, 22);
            this.time.TabIndex = 0;
            this.time.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "x1";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Consolas", 10F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(52, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(48, 17);
            this.title.TabIndex = 2;
            this.title.Text = "title";
            // 
            // nt1
            // 
            this.nt1.Icon = ((System.Drawing.Icon)(resources.GetObject("nt1.Icon")));
            this.nt1.Text = "x1 Status";
            this.nt1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.p_Media);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1692, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 38);
            this.panel1.TabIndex = 4;
            // 
            // p_Media
            // 
            this.p_Media.Controls.Add(this.p_Forward);
            this.p_Media.Controls.Add(this.p_Back);
            this.p_Media.Location = new System.Drawing.Point(78, 5);
            this.p_Media.Name = "p_Media";
            this.p_Media.Size = new System.Drawing.Size(64, 28);
            this.p_Media.TabIndex = 8;
            this.p_Media.Visible = false;
            // 
            // p_Forward
            // 
            this.p_Forward.Image = global::x1.Properties.Resources.forward;
            this.p_Forward.Location = new System.Drawing.Point(34, 3);
            this.p_Forward.Name = "p_Forward";
            this.p_Forward.Size = new System.Drawing.Size(24, 22);
            this.p_Forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Forward.TabIndex = 7;
            this.p_Forward.TabStop = false;
            this.p_Forward.Click += new System.EventHandler(this.p_Forward_Click);
            // 
            // p_Back
            // 
            this.p_Back.Image = global::x1.Properties.Resources.back;
            this.p_Back.Location = new System.Drawing.Point(5, 3);
            this.p_Back.Name = "p_Back";
            this.p_Back.Size = new System.Drawing.Size(24, 22);
            this.p_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Back.TabIndex = 6;
            this.p_Back.TabStop = false;
            this.p_Back.Click += new System.EventHandler(this.p_Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1920, 40);
            this.Controls.Add(this.title);
            this.Controls.Add(this.time);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "x1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_Media.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_Forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NotifyIcon nt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox p_Forward;
        private System.Windows.Forms.PictureBox p_Back;
        private System.Windows.Forms.Panel p_Media;
        private System.Windows.Forms.Label label4;
    }
}

