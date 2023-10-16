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
    public partial class ContactDetailsForm : Form
    {
        public ContactDetailsForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Get a reference to the MainForm if it exists.
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.darkPanel.Visible = false;
                mainForm.darkPanel.SendToBack();
                //mainForm.addNContactBtn.Animated = true;
                Close();
            }
        }
    }
}
