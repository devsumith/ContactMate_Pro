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
        short selectedPage = 1;
        int listIndex = 1;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region FUNCTION TO ADD NEW CONTACT

        private void addNContactBtn_Click(object sender, EventArgs e)
        {
            Guna2CustomGradientPanel panel = Controls.Find($"cPanel{listIndex}", true).FirstOrDefault() as Guna2CustomGradientPanel;

            ContactControl contactControl = new ContactControl();

            panel.ShadowDecoration.Enabled = true;
            panel.Controls.Add(contactControl);

            listIndex++;
        }

        #endregion

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

        #region FUNCTIONS FOR PAGE CONTROL

        private void pageControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected page number by converting the text of the selected tab to an integer.
            selectedPage = Convert.ToInt16(pageControl.SelectedTab.Text);

            // Enable or disable the previous page button based on whether the selected page is the first page.
            if (selectedPage == 1)
                prevPageBtn.Enabled = false;
            else
                prevPageBtn.Enabled = true;
        }

        private void prevPageBtn_Click(object sender, EventArgs e)
        {
            // Check if the previous page is a multiple of 3.
            if ((selectedPage - 1) % 3 == 0)
            {
                // Decrease the page numbers of all tabs in the TabControl by 3.
                for (int i = 0; i < 3; i++)
                    pageControl.TabPages[i].Text = (Convert.ToInt16(pageControl.TabPages[i].Text) - 3).ToString();

                // Set the selected index to the last tab.
                pageControl.SelectedIndex = 2;
            }
            else // If not, simply move to the previous tab.
                pageControl.SelectedIndex -= 1;
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            // Check if the current page is a multiple of 3.
            if (selectedPage % 3 == 0)
            {
                // Increase the page numbers of all tabs in the TabControl by 3.
                for (int i = 0; i < 3; i++)
                    pageControl.TabPages[i].Text = (Convert.ToInt16(pageControl.TabPages[i].Text) + 3).ToString();

                // Set the selected index to the first tab.
                pageControl.SelectedIndex = 0;
            }
            else // If not, simply move to the next tab.
                pageControl.SelectedIndex += 1;
        }

        #endregion
    }
}
