namespace FrontDesignRSC
{
    partial class RSCHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSCHome));
            this.IconPn = new System.Windows.Forms.Panel();
            this.UnityLogo = new System.Windows.Forms.PictureBox();
            this.LogoLbl = new System.Windows.Forms.Label();
            this.VOnOLbl = new System.Windows.Forms.Label();
            this.NavPnl = new System.Windows.Forms.Panel();
            this.InvIconPic = new System.Windows.Forms.PictureBox();
            this.InventoryTxtBx = new System.Windows.Forms.TextBox();
            this.IconPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnityLogo)).BeginInit();
            this.NavPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvIconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPn
            // 
            this.IconPn.BackColor = System.Drawing.Color.Transparent;
            this.IconPn.Controls.Add(this.UnityLogo);
            resources.ApplyResources(this.IconPn, "IconPn");
            this.IconPn.Name = "IconPn";
            // 
            // UnityLogo
            // 
            this.UnityLogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.UnityLogo, "UnityLogo");
            this.UnityLogo.Name = "UnityLogo";
            this.UnityLogo.TabStop = false;
            // 
            // LogoLbl
            // 
            resources.ApplyResources(this.LogoLbl, "LogoLbl");
            this.LogoLbl.BackColor = System.Drawing.Color.Transparent;
            this.LogoLbl.ForeColor = System.Drawing.Color.Red;
            this.LogoLbl.Name = "LogoLbl";
            // 
            // VOnOLbl
            // 
            resources.ApplyResources(this.VOnOLbl, "VOnOLbl");
            this.VOnOLbl.BackColor = System.Drawing.Color.Transparent;
            this.VOnOLbl.ForeColor = System.Drawing.Color.Lime;
            this.VOnOLbl.Name = "VOnOLbl";
            // 
            // NavPnl
            // 
            this.NavPnl.BackColor = System.Drawing.Color.Transparent;
            this.NavPnl.Controls.Add(this.InventoryTxtBx);
            this.NavPnl.Controls.Add(this.InvIconPic);
            resources.ApplyResources(this.NavPnl, "NavPnl");
            this.NavPnl.Name = "NavPnl";
            // 
            // InvIconPic
            // 
            resources.ApplyResources(this.InvIconPic, "InvIconPic");
            this.InvIconPic.Name = "InvIconPic";
            this.InvIconPic.TabStop = false;
            // 
            // InventoryTxtBx
            // 
            resources.ApplyResources(this.InventoryTxtBx, "InventoryTxtBx");
            this.InventoryTxtBx.BackColor = System.Drawing.SystemColors.MenuText;
            this.InventoryTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryTxtBx.ForeColor = System.Drawing.Color.Lime;
            this.InventoryTxtBx.Name = "InventoryTxtBx";
            this.InventoryTxtBx.ReadOnly = true;
            // 
            // RSCHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavPnl);
            this.Controls.Add(this.VOnOLbl);
            this.Controls.Add(this.LogoLbl);
            this.Controls.Add(this.IconPn);
            this.Name = "RSCHome";
            this.ShowIcon = false;
            this.IconPn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnityLogo)).EndInit();
            this.NavPnl.ResumeLayout(false);
            this.NavPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvIconPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel IconPn;
        private System.Windows.Forms.PictureBox UnityLogo;
        private System.Windows.Forms.Label LogoLbl;
        private System.Windows.Forms.Label VOnOLbl;
        private System.Windows.Forms.Panel NavPnl;
        private System.Windows.Forms.TextBox InventoryTxtBx;
        private System.Windows.Forms.PictureBox InvIconPic;
    }
}

