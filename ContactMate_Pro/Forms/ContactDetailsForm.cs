using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactMate_Pro
{
    public partial class ContactDetailsForm : Form
    {
        public ContactDetailsForm()
        {
            InitializeComponent();
        }

        #region FUNCTION FOR CLOSE BUTTON OF THE FORM

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Get a reference to the MainForm if it exists.
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.darkPanel.Visible = false;
                mainForm.darkPanel.SendToBack();
                mainForm.PerformLayout();

                Close();
            }
        }

        #endregion

        #region FUNCTIONS FOR HOVER STATE ANIMATION OF SELECT IMAGE BUTTON

        private void selectImageBtn_MouseEnter(object sender, EventArgs e) => selectImageBtn.Image = Properties.Resources.photo_camera;
        private void selectImageBtn_MouseLeave(object sender, EventArgs e) => selectImageBtn.Image = null;

        #endregion
    }
}
