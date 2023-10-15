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

        public Image ContactImage
        {
            get { return contactImage.Image; }
            set { contactImage.Image = value; }
        }

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
