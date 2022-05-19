namespace CoChan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bannerLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bannerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bannerLogo
            // 
            this.bannerLogo.Image = ((System.Drawing.Image)(resources.GetObject("bannerLogo.Image")));
            this.bannerLogo.Location = new System.Drawing.Point(-1, 0);
            this.bannerLogo.Name = "bannerLogo";
            this.bannerLogo.Size = new System.Drawing.Size(401, 160);
            this.bannerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerLogo.TabIndex = 1;
            this.bannerLogo.TabStop = false;
            this.bannerLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 160);
            this.Controls.Add(this.bannerLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoChan";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.bannerLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bannerLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

