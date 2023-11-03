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
    public partial class CGmailControl : UserControl
    {
        public CGmailControl()
        {
            InitializeComponent();
        }

        #region PROPERTY OF CONTACT GMAIL CONTROL

        public String GmailAddress
        {
            get { return gmailAddress.Text; }
            set { gmailAddress.Text = value; }
        }

        #endregion

        #region FUNCTION TO REMOVE THE CONTACT GMAIL CONTROL IN A LIST

        // This method is an event handler for the click event of the "removeBtn" button in your user control.
        private void removeBtn_Click(object sender, EventArgs e)
        {
            // Check if the Parent of the current control (the user control) is a FlowLayoutPanel.
            // If it is a FlowLayoutPanel, remove the current CGmailControl from the FlowLayoutPanel's Controls collection.
            // "this" refers to the current instance of the CGmailControl, so it is removed from the FlowLayoutPanel.
            if (Parent is FlowLayoutPanel flowLayoutPanel)
                flowLayoutPanel.Controls.Remove(this);
        }

        #endregion
    }
}
