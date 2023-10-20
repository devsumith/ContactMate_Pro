namespace ContactMate_Pro
{
    partial class ContactDetailsForm
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
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.selectImageBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.contactImageBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactImageBox)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessForm
            // 
            this.borderlessForm.AnimateWindow = true;
            this.borderlessForm.BorderRadius = 10;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.HasFormShadow = false;
            this.borderlessForm.ResizeForm = false;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Animated = true;
            this.closeBtn.BorderColor = System.Drawing.Color.DimGray;
            this.closeBtn.BorderRadius = 10;
            this.closeBtn.CustomClick = true;
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.IconColor = System.Drawing.Color.DimGray;
            this.closeBtn.Location = new System.Drawing.Point(337, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedColor = System.Drawing.Color.DimGray;
            this.closeBtn.Size = new System.Drawing.Size(38, 25);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 70;
            this.guna2CustomGradientPanel2.Controls.Add(this.selectImageBtn);
            this.guna2CustomGradientPanel2.Controls.Add(this.contactImageBox);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.SteelBlue;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(115, 36);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(150, 150);
            this.guna2CustomGradientPanel2.TabIndex = 30;
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Animated = true;
            this.selectImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectImageBtn.FillColor = System.Drawing.Color.Transparent;
            this.selectImageBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectImageBtn.ForeColor = System.Drawing.Color.White;
            this.selectImageBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.selectImageBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.selectImageBtn.Location = new System.Drawing.Point(5, 5);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.selectImageBtn.Size = new System.Drawing.Size(140, 140);
            this.selectImageBtn.TabIndex = 1;
            this.selectImageBtn.UseTransparentBackground = true;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            this.selectImageBtn.MouseEnter += new System.EventHandler(this.selectImageBtn_MouseEnter);
            this.selectImageBtn.MouseLeave += new System.EventHandler(this.selectImageBtn_MouseLeave);
            // 
            // contactImageBox
            // 
            this.contactImageBox.BackColor = System.Drawing.Color.Transparent;
            this.contactImageBox.FillColor = System.Drawing.Color.Honeydew;
            this.contactImageBox.Image = global::ContactMate_Pro.Properties.Resources.user__2_;
            this.contactImageBox.ImageRotate = 0F;
            this.contactImageBox.Location = new System.Drawing.Point(5, 5);
            this.contactImageBox.Name = "contactImageBox";
            this.contactImageBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.contactImageBox.Size = new System.Drawing.Size(140, 140);
            this.contactImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactImageBox.TabIndex = 0;
            this.contactImageBox.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightGreen;
            this.guna2Panel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2Panel1.Controls.Add(this.closeBtn);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(383, 196);
            this.guna2Panel1.TabIndex = 31;
            // 
            // ContactDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(383, 548);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactImageBox)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox contactImageBox;
        public Guna.UI2.WinForms.Guna2CircleButton selectImageBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}