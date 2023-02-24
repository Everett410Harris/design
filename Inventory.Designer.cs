namespace FrontDesignRSC
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.IconPn = new System.Windows.Forms.Panel();
            this.UnityLogo = new System.Windows.Forms.PictureBox();
            this.LogoLbl = new System.Windows.Forms.Label();
            this.VOnOLbl = new System.Windows.Forms.Label();
            this.InventoryTxtBx = new System.Windows.Forms.TextBox();
            this.InvIconPic = new System.Windows.Forms.PictureBox();
            this.IconPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnityLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvIconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPn
            // 
            this.IconPn.BackColor = System.Drawing.Color.Transparent;
            this.IconPn.Controls.Add(this.UnityLogo);
            this.IconPn.Location = new System.Drawing.Point(12, 12);
            this.IconPn.Name = "IconPn";
            this.IconPn.Size = new System.Drawing.Size(123, 68);
            this.IconPn.TabIndex = 1;
            // 
            // UnityLogo
            // 
            this.UnityLogo.BackColor = System.Drawing.Color.Transparent;
            this.UnityLogo.Image = ((System.Drawing.Image)(resources.GetObject("UnityLogo.Image")));
            this.UnityLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UnityLogo.Location = new System.Drawing.Point(19, 3);
            this.UnityLogo.Name = "UnityLogo";
            this.UnityLogo.Size = new System.Drawing.Size(91, 59);
            this.UnityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnityLogo.TabIndex = 0;
            this.UnityLogo.TabStop = false;
            // 
            // LogoLbl
            // 
            this.LogoLbl.AutoSize = true;
            this.LogoLbl.BackColor = System.Drawing.Color.Transparent;
            this.LogoLbl.Font = new System.Drawing.Font("Rebuffed", 20.25F);
            this.LogoLbl.ForeColor = System.Drawing.Color.Red;
            this.LogoLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoLbl.Location = new System.Drawing.Point(141, 28);
            this.LogoLbl.Name = "LogoLbl";
            this.LogoLbl.Size = new System.Drawing.Size(285, 35);
            this.LogoLbl.TabIndex = 2;
            this.LogoLbl.Text = "RED SKULL CUSTOMS";
            // 
            // VOnOLbl
            // 
            this.VOnOLbl.AutoSize = true;
            this.VOnOLbl.BackColor = System.Drawing.Color.Transparent;
            this.VOnOLbl.Font = new System.Drawing.Font("Georgia Pro Cond", 20.25F, System.Drawing.FontStyle.Bold);
            this.VOnOLbl.ForeColor = System.Drawing.Color.Lime;
            this.VOnOLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VOnOLbl.Location = new System.Drawing.Point(6, 109);
            this.VOnOLbl.Name = "VOnOLbl";
            this.VOnOLbl.Size = new System.Drawing.Size(407, 31);
            this.VOnOLbl.TabIndex = 3;
            this.VOnOLbl.Text = "VETERAN OWNED & OPERATED";
            this.VOnOLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InventoryTxtBx
            // 
            this.InventoryTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InventoryTxtBx.BackColor = System.Drawing.SystemColors.MenuText;
            this.InventoryTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryTxtBx.Font = new System.Drawing.Font("Georgia Pro", 15.75F);
            this.InventoryTxtBx.ForeColor = System.Drawing.Color.Lime;
            this.InventoryTxtBx.Location = new System.Drawing.Point(745, 28);
            this.InventoryTxtBx.Name = "InventoryTxtBx";
            this.InventoryTxtBx.ReadOnly = true;
            this.InventoryTxtBx.Size = new System.Drawing.Size(89, 24);
            this.InventoryTxtBx.TabIndex = 4;
            this.InventoryTxtBx.Text = "Inventory";
            // 
            // InvIconPic
            // 
            this.InvIconPic.Image = ((System.Drawing.Image)(resources.GetObject("InvIconPic.Image")));
            this.InvIconPic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvIconPic.Location = new System.Drawing.Point(683, 12);
            this.InvIconPic.Name = "InvIconPic";
            this.InvIconPic.Size = new System.Drawing.Size(56, 39);
            this.InvIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InvIconPic.TabIndex = 5;
            this.InvIconPic.TabStop = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1247, 793);
            this.Controls.Add(this.InvIconPic);
            this.Controls.Add(this.InventoryTxtBx);
            this.Controls.Add(this.VOnOLbl);
            this.Controls.Add(this.LogoLbl);
            this.Controls.Add(this.IconPn);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.IconPn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnityLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvIconPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel IconPn;
        private System.Windows.Forms.PictureBox UnityLogo;
        private System.Windows.Forms.Label LogoLbl;
        private System.Windows.Forms.Label VOnOLbl;
        private System.Windows.Forms.TextBox InventoryTxtBx;
        private System.Windows.Forms.PictureBox InvIconPic;
    }
}