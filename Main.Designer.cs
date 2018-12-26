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
            this.panel_StuffHere = new System.Windows.Forms.Panel();
            this.p_Media = new System.Windows.Forms.Panel();
            this.p_Forward = new System.Windows.Forms.PictureBox();
            this.p_Back = new System.Windows.Forms.PictureBox();
            this.seperator = new System.Windows.Forms.Label();
            this.btry = new System.Windows.Forms.Label();
            this.spotifytrack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.panel_StuffHere.SuspendLayout();
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
            this.time.Location = new System.Drawing.Point(441, 8);
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
            // panel_StuffHere
            // 
            this.panel_StuffHere.Controls.Add(this.time);
            this.panel_StuffHere.Controls.Add(this.p_Media);
            this.panel_StuffHere.Controls.Add(this.seperator);
            this.panel_StuffHere.Controls.Add(this.btry);
            this.panel_StuffHere.Controls.Add(this.spotifytrack);
            this.panel_StuffHere.Location = new System.Drawing.Point(232, 1);
            this.panel_StuffHere.Name = "panel_StuffHere";
            this.panel_StuffHere.Size = new System.Drawing.Size(509, 38);
            this.panel_StuffHere.TabIndex = 4;
            // 
            // p_Media
            // 
            this.p_Media.Controls.Add(this.p_Forward);
            this.p_Media.Controls.Add(this.p_Back);
            this.p_Media.Location = new System.Drawing.Point(300, 7);
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
            // seperator
            // 
            this.seperator.AutoSize = true;
            this.seperator.Font = new System.Drawing.Font("Consolas", 13F);
            this.seperator.ForeColor = System.Drawing.Color.White;
            this.seperator.Location = new System.Drawing.Point(424, 8);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(20, 22);
            this.seperator.TabIndex = 5;
            this.seperator.Text = "|";
            // 
            // btry
            // 
            this.btry.AutoSize = true;
            this.btry.Font = new System.Drawing.Font("Consolas", 13F);
            this.btry.ForeColor = System.Drawing.Color.White;
            this.btry.Location = new System.Drawing.Point(361, 8);
            this.btry.Name = "btry";
            this.btry.Size = new System.Drawing.Size(70, 22);
            this.btry.TabIndex = 9;
            this.btry.Text = "[----]";
            this.btry.MouseHover += new System.EventHandler(this.btry_MouseHover);
            // 
            // spotifytrack
            // 
            this.spotifytrack.Font = new System.Drawing.Font("Consolas", 12F);
            this.spotifytrack.ForeColor = System.Drawing.Color.White;
            this.spotifytrack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spotifytrack.Location = new System.Drawing.Point(33, 11);
            this.spotifytrack.Margin = new System.Windows.Forms.Padding(0);
            this.spotifytrack.Name = "spotifytrack";
            this.spotifytrack.Size = new System.Drawing.Size(263, 19);
            this.spotifytrack.TabIndex = 10;
            this.spotifytrack.Text = "track";
            this.spotifytrack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ClientSize = new System.Drawing.Size(739, 40);
            this.Controls.Add(this.panel_StuffHere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "x1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_StuffHere.ResumeLayout(false);
            this.panel_StuffHere.PerformLayout();
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
        private System.Windows.Forms.Panel panel_StuffHere;
        private System.Windows.Forms.Label seperator;
        private System.Windows.Forms.PictureBox p_Forward;
        private System.Windows.Forms.PictureBox p_Back;
        private System.Windows.Forms.Panel p_Media;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btry;
        private System.Windows.Forms.Label spotifytrack;
        private System.Windows.Forms.ToolTip ttp;
    }
}

