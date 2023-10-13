using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactMate_Pro
{
    public partial class LoadingScreenForm : Form
    {
        public LoadingScreenForm()
        {
            InitializeComponent();
        }

        private void LoadingScreenForm_Load(object sender, EventArgs e)
        {
            elipse.TargetControl = this;

            // When the form loads, start the background worker.
            backgroundWorker.RunWorkerAsync();
        }

        #region FUNCTIONS FOR LOADING SCREEN

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // This method runs in a separate background thread.

            for (int i = 0; i <= 100; i++)
            {
                // Simulate a delay of 50 milliseconds to represent work being done.
                System.Threading.Thread.Sleep(50);

                // Increase the value of the progress bar by 1.
                progressBar.Value += 1;

                // Use Invoke to update the 'loadingPercent' label's text from a different thread.
                loadingPercent.Invoke((MethodInvoker)delegate
                {
                    // Update the label text to show the current progress as a percentage.
                    loadingPercent.Text = $"{progressBar.Value} %";
                });
            }

            // This block of code is executed after the progress bar reaches 100%.
            this.Invoke((MethodInvoker)delegate
            {
                // Hide the current form (LoadingScreenForm).
                this.Hide();
                var form = new MainForm();
                // Attach an event handler to the 'FormClosed' event of the 'MainForm'.
                form.FormClosed += (s, args) => this.Close();
                // Show the 'MainForm'.
                form.Show();
            });
        }

        #endregion
    }
}
