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
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        #region PROPERTIES OF CONTACT CONTROL

        public Image ContactImage
        {
            get { return contactImage.Image; }
            set { contactImage.Image = value; }
        }

        public String ContactName
        {
            get { return contactNameLabel.Text; }
            set { contactNameLabel.Text = value;}
        }

        public String ContactNumber
        {
            get { return contactNumLabel.Text; }
            set { contactNumLabel.Text = value; }
        }

        public String ContactGmail
        {
            get { return contactGmailLabel.Text; }
            set { contactGmailLabel.Text = value; }
        }

        #endregion

        #region FUNCTIONS FOR HOVER UI DESIGN OF VIEW CONTACT BUTTON

        private void viewContactBtn_MouseEnter(object sender, EventArgs e)
        {
            contactNameLabel.ForeColor = Color.PaleGreen;
        }

        private void viewContactBtn_MouseLeave(object sender, EventArgs e)
        {
            contactNameLabel.ForeColor = Color.MintCream;
        }

        #endregion
    }
}
