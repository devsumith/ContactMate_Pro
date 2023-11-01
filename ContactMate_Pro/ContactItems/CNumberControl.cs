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
    }
}
