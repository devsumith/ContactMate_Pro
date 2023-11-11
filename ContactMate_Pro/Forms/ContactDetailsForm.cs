using ContactMate_Pro.Classes;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactMate_Pro
{
    public partial class ContactDetailsForm : Form
    {
        #region CLASSES

        // Instance of class that will store the validated contact details.
        ContactDetails contactDetails = new ContactDetails();

        Functionality functions = new Functionality();

        #endregion

        #region FIELDS

        // Fields for contact number and gmail address.
        List<String> contactNumberList = new List<String>();
        List<String> gmailAddressList = new List<String>();

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
                functions.Alert("New contact added successfully.", AlertForm.Type.Success);
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

            bool ifReturn = true;

            foreach (Control control in controlList)
            {
                switch (control)
                {
                    case Guna2TextBox textBox when textBox == nicknameBox:
                        if (String.IsNullOrEmpty(textBox.Text))
                        {
                            functions.Alert("Complete the nickname field.", AlertForm.Type.Info);
                            return false;
                        }
                        break;
                    case Guna2ComboBox comboBox when comboBox == relationCBox:
                        if (comboBox.SelectedIndex == 0)
                        {
                            functions.Alert("Select the contact relationship.", AlertForm.Type.Info);
                            return false;
                        }
                        break;
                    case FlowLayoutPanel layoutPanel when layoutPanel == cNumLayoutPanel:
                        if (layoutPanel.Controls.Count == 0)
                        {
                            functions.Alert("Add atleast one contact number.", AlertForm.Type.Info);
                            return false;
                        }
                        break;
                    case FlowLayoutPanel layoutPanel when layoutPanel == cGmailLayoutPanel:
                        if (layoutPanel.Controls.Count == 0)
                        {
                            functions.Alert("Add atleast one Gmail address.", AlertForm.Type.Info);
                            return false;
                        }
                        break;

                    // Cases for Guna2TextBox with various link boxes as specific controls
                    // Check if the text is not empty, and call LinksValidation function
                    case Guna2TextBox textBox when textBox == facebookLinkBox:
                        if (!String.IsNullOrEmpty(textBox.Text))
                            ifReturn = LinksValidation(textBox, contactDetails, "FacebookLink");
                        break;
                    case Guna2TextBox textBox when textBox == instagramLinkBox:
                        if (!String.IsNullOrEmpty(textBox.Text))
                            ifReturn = LinksValidation(textBox, contactDetails, "InstagramLink");
                        break;
                    case Guna2TextBox textBox when textBox == linkedInLinkBox:
                        if (!String.IsNullOrEmpty(textBox.Text))
                            ifReturn = LinksValidation(textBox, contactDetails, "LinkedInLink");
                        break;
                    case Guna2TextBox textBox when textBox == xLinkBox:
                        if (!String.IsNullOrEmpty(textBox.Text))
                            ifReturn = LinksValidation(textBox, contactDetails, "TwitterLink");
                        break;
                    case Guna2TextBox textBox when textBox == gitHubLinkBox:
                        if (!String.IsNullOrEmpty(textBox.Text))
                            ifReturn = LinksValidation(textBox, contactDetails, "GitHubLink");
                        break;
                    case Guna2TextBox textBox when textBox == threadsLinkBox:
                        if (!String.IsNullOrEmpty(textBox.Text))
                            ifReturn = LinksValidation(textBox, contactDetails, "ThreadsLink");
                        break;
                }

                // If above statement return a false value for ifReturn, this statement will return false to indicate validation failure.
                if (!ifReturn)
                    return false;
            }

            return true;
        }

        #endregion

        #region FUNCTION TO VALIDATE LINKS

        // It will return true if there is an issue; otherwise, it will return false.
        private bool LinksValidation(Control textBox, ContactDetails contactDetails, string property)
        {
            string input = textBox.Text.Trim();

            // Using reflection, set the value of the specified property in the 'studentData' object to the 'input'
            contactDetails.GetType().GetProperty(property).SetValue(contactDetails, input);

            // Using reflection, get the value of the specified property in the 'studentData' object,
            // convert it to a string, check if it's empty or null
            if (string.IsNullOrEmpty(contactDetails.GetType().GetProperty(property).GetValue(contactDetails) as string))
            {
                textBox.Focus();

                return false;
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

        #region FUNCTION TO ADD CONTACT NUMBER IN A LIST

        private void addCNumBtn_Click(object sender, EventArgs e)
        {
            string pattern = @"^(09\d{9}|(\+63|0)[2-8]\d{7})$";

            if (!String.IsNullOrEmpty(cNumBox.Text) && Regex.IsMatch(cNumBox.Text, pattern) && !contactNumberList.Contains(cNumBox.Text))
            {
                CNumberControl cNumberControl = new CNumberControl
                {
                    ContactNumber = cNumBox.Text
                };

                cNumLayoutPanel.Controls.Add(cNumberControl);
                cNumberControl.Size = new Size(129, 30);

                contactNumberList.Add(cNumBox.Text);

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
