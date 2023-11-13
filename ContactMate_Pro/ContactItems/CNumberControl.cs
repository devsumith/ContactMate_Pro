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
    public partial class CNumberControl : UserControl
    {
        public CNumberControl()
        {
            InitializeComponent();
        }

        #region PROPERTY OF CONTACT NUMBER CONTROL

        public String ContactNumber
        {
            get { return contactNumber.Text; }
            set { contactNumber.Text = value; }
        }

        #endregion

        #region FUNCTION TO REMOVE THE CONTACT NUMBER CONTROL IN A LIST

        // This method is an event handler for the click event of the "removeBtn" button in your user control.
        private void removeBtn_Click(object sender, EventArgs e)
        {
            // Check if the Parent of the current control (the user control) is a FlowLayoutPanel.
            // If it is a FlowLayoutPanel, remove the current CNumberControl from the FlowLayoutPanel's Controls collection.
            // "this" refers to the current instance of the CNumberControl, so it is removed from the FlowLayoutPanel.
            if (Parent is FlowLayoutPanel flowLayoutPanel)
            {
                flowLayoutPanel.Controls.Remove(this);

                ContactDetailsForm contactDetailsForm = Application.OpenForms.OfType<ContactDetailsForm>().FirstOrDefault();
                contactDetailsForm.RemoveContactNumber(ContactNumber);
            }
        }

        #endregion
    }
}
