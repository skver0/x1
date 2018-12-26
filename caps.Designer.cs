namespace x1
{
    partial class caps
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
            this.capsindicator = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // capsindicator
            // 
            this.capsindicator.BackColor = System.Drawing.Color.Transparent;
            this.capsindicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capsindicator.Font = new System.Drawing.Font("Consolas", 25F);
            this.capsindicator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.capsindicator.Location = new System.Drawing.Point(0, 0);
            this.capsindicator.Name = "capsindicator";
            this.capsindicator.Size = new System.Drawing.Size(263, 279);
            this.capsindicator.TabIndex = 1;
            this.capsindicator.Text = "a";
            this.capsindicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // caps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(263, 279);
            this.Controls.Add(this.capsindicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(263, 279);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(263, 279);
            this.Name = "";
            this.ShowIcon = false;  
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.caps_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label capsindicator;
        private System.Windows.Forms.Timer t1;
    }
}