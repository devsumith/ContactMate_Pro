namespace ContactMate_Pro
{
    partial class LoadingScreenForm
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
            this.loginFormPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.loadingPercent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.animatedWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.loginFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFormPanel
            // 
            this.loginFormPanel.Controls.Add(this.loadingPercent);
            this.loginFormPanel.Controls.Add(this.guna2HtmlLabel2);
            this.loginFormPanel.Controls.Add(this.progressBar);
            this.loginFormPanel.Controls.Add(this.guna2HtmlLabel1);
            this.loginFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFormPanel.FillColor = System.Drawing.Color.LimeGreen;
            this.loginFormPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.loginFormPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginFormPanel.FillColor4 = System.Drawing.Color.SteelBlue;
            this.loginFormPanel.Location = new System.Drawing.Point(0, 0);
            this.loginFormPanel.Name = "loginFormPanel";
            this.loginFormPanel.Size = new System.Drawing.Size(540, 322);
            this.loginFormPanel.TabIndex = 3;
            // 
            // loadingPercent
            // 
            this.loadingPercent.BackColor = System.Drawing.Color.Transparent;
            this.loadingPercent.Enabled = false;
            this.loadingPercent.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingPercent.ForeColor = System.Drawing.Color.White;
            this.loadingPercent.Location = new System.Drawing.Point(12, 281);
            this.loadingPercent.Name = "loadingPercent";
            this.loadingPercent.Size = new System.Drawing.Size(31, 25);
            this.loadingPercent.TabIndex = 6;
            this.loadingPercent.Text = "0 %";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Enabled = false;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(90, 171);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(360, 25);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "POWERED BY JIRO LAURENZ SAMIA AGAD";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderColor = System.Drawing.Color.Transparent;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 312);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.SteelBlue;
            this.progressBar.ShadowDecoration.BorderRadius = 1;
            this.progressBar.Size = new System.Drawing.Size(540, 10);
            this.progressBar.TabIndex = 4;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Enabled = false;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(116, 115);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(309, 60);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "CONTACT MATE PRO";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // animatedWindow
            // 
            this.animatedWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animatedWindow.TargetForm = this;
            // 
            // LoadingScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 322);
            this.Controls.Add(this.loginFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary Planner Pro";
            this.Load += new System.EventHandler(this.LoadingScreenForm_Load);
            this.loginFormPanel.ResumeLayout(false);
            this.loginFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel loginFormPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel loadingPercent;
        private Guna.UI2.WinForms.Guna2AnimateWindow animatedWindow;
    }
}