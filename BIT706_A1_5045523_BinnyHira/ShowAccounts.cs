using System;
using System.Windows.Forms;

namespace BIT706_A1_5045523_BinnyHira
{
    public partial class ShowAccounts : ParentForm
    {
        public ShowAccounts()
        {
            InitializeComponent();
            updateLabel();
            DisplayCustomersAccounts();            
        }
        public void updateLabel()
        {
            string labelTxt = ($"ID - {SelectedCust.PersonID.ToString()} Name - " +
                $"{SelectedCust.Name}");
            customerLabel.Text = labelTxt;
        }

        public void DisplayCustomersAccounts()
        {
            //make sure listbox is empty
            lstAccounts.Items.Clear();
            //Add the book titles to the listBox
            foreach (AAccounts acc in AllAccounts)
            {
                if (acc.Customer.PersonID == SelectedCust.PersonID)
                {
                    lstAccounts.Items.Add(acc);                    
                }
            }
            
            //Select the first item
            lstAccounts.SelectedIndex = 0;
        }

        private void btnGetAccount_Click(object sender, EventArgs e)
        {
            SelectedAcc = (AAccounts)lstAccounts.SelectedItem;
            lstAccInfo.Text = SelectedAcc.toStringListAccounts();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            DisplayCustomersAccounts();
            SelectedAcc = null;
            lstAccInfo.Text = "";
        }
    }
}
