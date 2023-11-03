namespace ContactMate_Pro
{
    partial class CNumberControl
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.removeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.contactNumber = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.guna2Panel1.BorderRadius = 3;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.removeBtn);
            this.guna2Panel1.Controls.Add(this.contactNumber);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.MintCream;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(129, 30);
            this.guna2Panel1.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.Animated = true;
            this.removeBtn.BorderRadius = 5;
            this.removeBtn.CustomClick = true;
            this.removeBtn.FillColor = System.Drawing.Color.Transparent;
            this.removeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeBtn.IconColor = System.Drawing.Color.DarkOliveGreen;
            this.removeBtn.Location = new System.Drawing.Point(103, 3);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(20, 20);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumber.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.contactNumber.Location = new System.Drawing.Point(7, 3);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(87, 22);
            this.contactNumber.TabIndex = 0;
            this.contactNumber.Text = "09392723942";
            // 
            // CNumberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CNumberControl";
            this.Size = new System.Drawing.Size(129, 30);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label contactNumber;
        private Guna.UI2.WinForms.Guna2ControlBox removeBtn;
    }
}
