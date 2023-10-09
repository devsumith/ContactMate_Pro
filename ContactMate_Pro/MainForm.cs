using Guna.UI2.WinForms;
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
    public partial class MainForm : Form
    {
        #region FIELDS

            TabPage previousTab = null;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region FUNCTION TO UPDATE THE TIME AND DATE LABEL EVERY 100 MILLISECONDS 

        private void timerTick_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToShortTimeString();
            dateLabel.Text = DateTime.Now.ToShortDateString();
        }

        #endregion

        #region FUNCTIONS FOR CLEAR BUTTON OF FILTRATION

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Get the currently selected tab from the 'filterTab' TabControl.
            TabPage selectedTab = filterTab.SelectedTab;

            // If not null, call the 'ClearControlsInSelectedTab' method to clear controls within the selected tab.
            if (selectedTab != null) 
                ClearControlsInSelectedTab(selectedTab);
        }

        private void ClearControlsInSelectedTab(TabPage selectedTab)
        {
            // Iterate through all controls within the selected tab and clear them.
            foreach (Control control in selectedTab.Controls)
            {
                if (control is Guna2CheckBox checkBox)
                    checkBox.Checked = false;
                else if (control is Guna2RadioButton radioButton)
                    radioButton.Checked = false;
                else if (control is Guna2ComboBox comboBox)
                    comboBox.SelectedIndex = 0;
            }
        }

        #endregion

        #region FUNCTION TO CLEAR THE FILTRATION OF PREVIOUS TAB

        private void filterTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if 'previousTab' is null, which means it is the first time that selected index has changed.
            // Therefore, it will clear the first tab.
            // If not null, the tab that will be cleared is the previous one.
            if (previousTab == null)
                ClearControlsInSelectedTab(filterTab.TabPages[0]);
            else
                ClearControlsInSelectedTab(previousTab);

            previousTab = filterTab.SelectedTab;
        }

        #endregion

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
