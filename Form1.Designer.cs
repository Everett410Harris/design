namespace FrontDesignRSC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BKGRDImage = new System.Windows.Forms.Panel();
            this.LogTxtBx = new System.Windows.Forms.PictureBox();
            this.UnityLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BKGRDImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogTxtBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnityLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BKGRDImage
            // 
            this.BKGRDImage.Controls.Add(this.textBox1);
            this.BKGRDImage.Controls.Add(this.UnityLogo);
            this.BKGRDImage.Controls.Add(this.LogTxtBx);
            resources.ApplyResources(this.BKGRDImage, "BKGRDImage");
            this.BKGRDImage.Name = "BKGRDImage";
            // 
            // LogTxtBx
            // 
            this.LogTxtBx.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LogTxtBx, "LogTxtBx");
            this.LogTxtBx.Name = "LogTxtBx";
            this.LogTxtBx.TabStop = false;
            // 
            // UnityLogo
            // 
            this.UnityLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.UnityLogo, "UnityLogo");
            this.UnityLogo.Name = "UnityLogo";
            this.UnityLogo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.SpringGreen;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BKGRDImage);
            this.Name = "Form1";
            this.BKGRDImage.ResumeLayout(false);
            this.BKGRDImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogTxtBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnityLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BKGRDImage;
        private System.Windows.Forms.PictureBox LogTxtBx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox UnityLogo;
    }
}

