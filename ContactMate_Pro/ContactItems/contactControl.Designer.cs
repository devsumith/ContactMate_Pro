namespace ContactMate_Pro
{
    partial class ContactControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactControl));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.viewContactBtn = new Guna.UI2.WinForms.Guna2Button();
            this.imagePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.contactImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.contactGmailLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contactNumLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contactNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.viewContactBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.imagePanel);
            this.guna2CustomGradientPanel1.Controls.Add(this.contactGmailLabel);
            this.guna2CustomGradientPanel1.Controls.Add(this.contactNumLabel);
            this.guna2CustomGradientPanel1.Controls.Add(this.contactNameLabel);
            this.guna2CustomGradientPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.SteelBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 10;
            this.guna2CustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.DarkOliveGreen;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(226, 114);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            //this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // viewContactBtn
            // 
            this.viewContactBtn.Animated = true;
            this.viewContactBtn.BorderRadius = 3;
            this.viewContactBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewContactBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewContactBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewContactBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewContactBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewContactBtn.FillColor = System.Drawing.Color.MintCream;
            this.viewContactBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewContactBtn.ForeColor = System.Drawing.Color.White;
            this.viewContactBtn.HoverState.FillColor = System.Drawing.Color.PaleGreen;
            this.viewContactBtn.Location = new System.Drawing.Point(5, 10);
            this.viewContactBtn.Name = "viewContactBtn";
            this.viewContactBtn.Size = new System.Drawing.Size(10, 95);
            this.viewContactBtn.TabIndex = 48;
            this.viewContactBtn.MouseEnter += new System.EventHandler(this.viewContactBtn_MouseEnter);
            this.viewContactBtn.MouseLeave += new System.EventHandler(this.viewContactBtn_MouseLeave);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BorderRadius = 30;
            this.imagePanel.Controls.Add(this.contactImage);
            this.imagePanel.FillColor = System.Drawing.Color.MintCream;
            this.imagePanel.Location = new System.Drawing.Point(159, 10);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(60, 60);
            this.imagePanel.TabIndex = 43;
            // 
            // contactImage
            // 
            this.contactImage.BackColor = System.Drawing.Color.Transparent;
            this.contactImage.FillColor = System.Drawing.Color.MintCream;
            this.contactImage.Image = ((System.Drawing.Image)(resources.GetObject("contactImage.Image")));
            this.contactImage.ImageRotate = 0F;
            this.contactImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contactImage.Location = new System.Drawing.Point(3, 3);
            this.contactImage.Name = "contactImage";
            this.contactImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.contactImage.Size = new System.Drawing.Size(55, 55);
            this.contactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contactImage.TabIndex = 3;
            this.contactImage.TabStop = false;
            this.contactImage.UseTransparentBackground = true;
            // 
            // contactGmailLabel
            // 
            this.contactGmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactGmailLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactGmailLabel.ForeColor = System.Drawing.Color.MintCream;
            this.contactGmailLabel.Location = new System.Drawing.Point(21, 83);
            this.contactGmailLabel.Name = "contactGmailLabel";
            this.contactGmailLabel.Size = new System.Drawing.Size(150, 21);
            this.contactGmailLabel.TabIndex = 46;
            this.contactGmailLabel.Text = "jirolaurenz0101@gmail.com";
            // 
            // contactNumLabel
            // 
            this.contactNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactNumLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumLabel.ForeColor = System.Drawing.Color.MintCream;
            this.contactNumLabel.Location = new System.Drawing.Point(21, 60);
            this.contactNumLabel.Name = "contactNumLabel";
            this.contactNumLabel.Size = new System.Drawing.Size(87, 25);
            this.contactNumLabel.TabIndex = 45;
            this.contactNumLabel.Text = "09392723942";
            // 
            // contactNameLabel
            // 
            this.contactNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNameLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.contactNameLabel.Location = new System.Drawing.Point(21, 7);
            this.contactNameLabel.Name = "contactNameLabel";
            this.contactNameLabel.Size = new System.Drawing.Size(96, 27);
            this.contactNameLabel.TabIndex = 44;
            this.contactNameLabel.Text = "JIRO LAURENZ";
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(226, 114);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel imagePanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox contactImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel contactGmailLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel contactNumLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel contactNameLabel;
        private Guna.UI2.WinForms.Guna2Button viewContactBtn;
    }
}
