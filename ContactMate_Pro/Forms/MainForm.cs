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

        #region FIELDS FOR PAGE CONTROL

        private TabPage previousTab = null;
        private short selectedPage = 1;

        #endregion

        #region FIELDS FOR GENERATING NEW CONTACT PANEL

        private int panelCount = 0;
        private int xStart = 24;
        private int yStart = 60;
        private int xSpacing = 246;
        private int ySpacing = 134;

        #endregion

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region FUNCTIONS TO ADD NEW CONTACT DETAILS

        private async void addNContactBtn_Click(object sender, EventArgs e)
        {
            await ShowingContactDetailsFormAsync();

            AddNewContactControl();
        }

        #region PROCESS TO ADD NEW CONTACT DETAILS

        private async Task ShowingContactDetailsFormAsync()
        {
            // Wait for a short delay to allow the animation to finish.
            await Task.Delay(450);

            // Show the "darkPanel" and bringing it to front.
            darkPanel.Show();
            darkPanel.BringToFront();

            await Task.Delay(400);

            // Show the ContactDetailsForm in dialog.
            ContactDetailsForm contactDetailsForm = new ContactDetailsForm();
            contactDetailsForm.ShowDialog();
        }

        private void AddNewContactControl()
        {
            // Check if the maximum number of panels (16) has been reached.
            if (panelCount < 16)
            {
                // Create a new instance of ContactControl (assuming this is a custom user control).
                ContactControl contactControl = new ContactControl();

                // Calculate the location (position) of the new panel based on its index.
                // The xStart and yStart values define the starting position.
                // xSpacing and ySpacing define the horizontal and vertical spacing between panels.
                contactControl.Location = new Point(xStart + (panelCount % 4 * xSpacing), yStart + (panelCount / 4 * ySpacing));

                // Add the newly created ContactControl to the bodyPanel, assuming bodyPanel is the container.
                bodyPanel.Controls.Add(contactControl);

                // Set the Name property of the ContactControl to "cPanelX" where X is the panelCount.
                contactControl.Name = $"cPanel{panelCount++}";
            }
        }

        #endregion

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

        #region FUNCTION TO BACK IN PREVIOUS PAGE

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

        #endregion

        #region FUNCTION TO NEXT THE PAGE

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

        #endregion
    }
}
