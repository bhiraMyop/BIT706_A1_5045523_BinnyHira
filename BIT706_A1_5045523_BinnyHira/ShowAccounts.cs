using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lstAccInfo.Text = SelectedAcc.ToString();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            DisplayCustomersAccounts();
            SelectedAcc = null;
            lstAccInfo.Text = "";
        }

        //Show Account details as a Message Box
        // if SelectedAcc is empty then show error message that no Account is selected. 
        private void showAccInfo_Click(object sender, EventArgs e)
        {
            string str = "";
            string accountType = "";

            if (SelectedAcc == null)
            {
                str = "ERROR! - No Account selected";
            }
            else if (SelectedAcc.GetType().Name == "EverydayAccount")
            {
                accountType = "Everyday Account";
            }
            else if (SelectedAcc.GetType().Name == "InvestmentAccount")
            {
                accountType = "Investment Account";
            }
            else if(SelectedAcc.GetType().Name == "OmniAccount")
            {
                accountType = "Omni Account";
            }

            if(SelectedAcc != null)
            {
                str = $"Account number - {SelectedAcc.AccountNo}\n" +
                $"Account Type - {accountType}\n" +
                $"Account Balance - ${SelectedAcc.Balance}\n" +
                $"Overdraft Allowed - {SelectedAcc.Overdraft.GetType()} \n" +
                $"Account number - {SelectedAcc.AccountNo} \n" +
                $"Account number - {SelectedAcc.AccountNo}";
            }


            MessageBox.Show(str);
        }
    }
}
