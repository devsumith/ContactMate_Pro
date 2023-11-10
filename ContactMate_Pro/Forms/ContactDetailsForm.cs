using ContactMate_Pro.Classes;
using Guna.UI2.WinForms;
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
        #region CLASSES

        Functionality functions = new Functionality();

        #endregion

        public ContactDetailsForm()
        {
            InitializeComponent();
        }

        #region FUNCTIONS TO ADD THE CONTACT DETAILS IN DATABASE

        private void addContactBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInformation())
            {

            }
        }

        #region FUNCTION FOR CONTACT DETAILS VALIDATION

        private bool ValidateInformation()
        {
            #region LIST OF CONTROLS THAT CONTAIN INFORMATION TO BE VALIDATED

            List<Control> controlList = new List<Control>
            {
                nicknameBox,
                relationCBox,
                cNumLayoutPanel,
                cGmailLayoutPanel,
                facebookLinkBox,
                instagramLinkBox,
                linkedInLinkBox,
                xLinkBox,
                gitHubLinkBox,
                threadsLinkBox
            };

            #endregion

            foreach (Control control in controlList)
            {
                switch (control)
                {
                    case Guna2TextBox textBox when textBox == nicknameBox:
                        if (String.IsNullOrEmpty(textBox.Text))
                        {

                            return false;
                        }
                        break;
                }
            }

            return true;
        }

        #endregion

        #endregion

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

        private void selectImageBtn_MouseEnter(object sender, EventArgs e) => selectImageBtn.Image = Properties.Resources.gallery;
        private void selectImageBtn_MouseLeave(object sender, EventArgs e) => selectImageBtn.Image = null;

        #endregion

        #region FUNCTIONS TO SELECT CONTACT IMAGE

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to allow only JPEG and PNG image files.
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png";

            // To handle any exceptions that might occur during the process.
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap selectedImage = new Bitmap(openFileDialog.FileName);

                    // Check if the loaded image is square using the IsSquareImage function.
                    // If the image is square, set it as the student's picture.
                    // Else, display a warning message.
                    if (IsSquareImage(selectedImage))
                        contactImageBox.Image = selectedImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting photo: {ex.Message}", "Diary Planner Pro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // This method checks if an image is square based on its width and height.
        private bool IsSquareImage(Bitmap image) => image.Width == image.Height;

        #endregion

        #region FUNCTION TO CHANGE THE RELATION COLOR DEPENDS ON SELECTED RELATION

        private void relationCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color[] relationColors =
            {
                Color.LightGray,            // DEFAULT
                Color.LightBlue,            // FAMILY
                Color.LightCoral,           // PARTNER
                Color.LightGreen,           // FRIEND
                Color.Lavender,             // NEIGHBORS
                Color.Aqua,                 // COLLEAGUES
                Color.PaleTurquoise,        // SCHOOL / UNIVERSITY
                Color.LightGoldenrodYellow, // PERSONAL SERVICE
                Color.PeachPuff,            // MEDICAL CONTACT
                Color.LightSalmon,          // PROFESSIONAL CONTACT
                Color.SaddleBrown           // OTHER
            };

            // Change the fill color of relationColor based on selected relation.
            relationColor.FillColor = relationColors[relationCBox.SelectedIndex];
        }

        #endregion

        #region FUNCTION TO ADD CONTACT NUMBERS IN A LIST

        private void addCNumBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cNumBox.Text))
            {
                CNumberControl cNumberControl = new CNumberControl();

                cNumberControl.ContactNumber = cNumBox.Text;

                cNumLayoutPanel.Controls.Add(cNumberControl);
                cNumberControl.Size = new Size(129, 30);

                cNumBox.Clear();

                cNumLayoutPanel.Refresh();
            }
        }

        private void cNumBox_KeyDown(object sender, KeyEventArgs e)
        {
            // When the Enter key is pressed in the cNumBox control, 
            // simulate a click event on the addCNumBtn button.
            if (e.KeyCode == Keys.Enter)
                addCNumBtn_Click(sender, e);
        }

        #endregion

        #region FUNCTION TO ADD CONTACT GMAIL IN A LIST

        private void addCGmailBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cGmailBox.Text))
            {
                CGmailControl cGmailControl = new CGmailControl();

                cGmailControl.GmailAddress = cGmailBox.Text;

                cGmailLayoutPanel.Controls.Add(cGmailControl);
                cGmailControl.Size = new Size(207, 30);

                cGmailBox.Clear();

                cGmailLayoutPanel.Refresh();
            }
        }

        private void cGmailBox_KeyDown(object sender, KeyEventArgs e)
        {
            // When the Enter key is pressed in the cGmailBox control, 
            // simulate a click event on the addCGmailBt button.
            if (e.KeyCode == Keys.Enter)
                addCGmailBtn_Click(sender, e);
        }

        #endregion
    }
}
