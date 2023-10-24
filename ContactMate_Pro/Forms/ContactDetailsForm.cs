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
    }
}
