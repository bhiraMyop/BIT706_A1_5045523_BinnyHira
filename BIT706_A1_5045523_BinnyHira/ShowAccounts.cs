using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BIT706_A1_5045523_BinnyHira
{
    public partial class ShowAccounts : ParentForm
    {//
        public ShowAccounts()
        {
            InitializeComponent();
            updateLabel();
            DisplayCustomersAccounts();
            amountLabel.Hide();
            textBoxAmount.Hide();
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
            amountLabel.Show();
            textBoxAmount.Show();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            DisplayCustomersAccounts();
            SelectedAcc = null;
            lstAccInfo.Text = "";
            amountLabel.Hide();
            textBoxAmount.Clear();
            textBoxAmount.Hide();
        }
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (SelectedAcc == null)
            {
                MessageBox.Show("ERROR! - No Account Selected.");
            }
            else if (string.IsNullOrEmpty(textBoxAmount.Text.ToString()) || textBoxAmount.Text.ToString() == " ")
            {
                MessageBox.Show("ERROR! - No Amount Entered.");
            }
            else
            {
                double dollarAmount = 0.0;

                if (double.TryParse($"{textBoxAmount.Text.ToString()}", out dollarAmount))
                {
                   double.TryParse(dollarAmount.ToString("N2"), out dollarAmount); //convert to 2 decimal places
                   MessageBox.Show(SelectedAcc.withdrawl(SelectedAcc, dollarAmount));
                   btnRefresh2.PerformClick();
                }
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (SelectedAcc == null)
            {
                MessageBox.Show("ERROR! - No Account Selected.");
            }
            else if (string.IsNullOrEmpty(textBoxAmount.Text.ToString()) || textBoxAmount.Text.ToString() == " " )
            {
                MessageBox.Show("ERROR! - No Amount Entered.");
            }
            else
            {
                double dollarAmount = 0.0;

                if (double.TryParse($"{textBoxAmount.Text.ToString()}", out dollarAmount))
                {
                    double.TryParse(dollarAmount.ToString("N2"), out dollarAmount); //convert to 2 decimal places
                    MessageBox.Show(SelectedAcc.deposit(SelectedAcc, dollarAmount));
                    btnRefresh2.PerformClick();
                }
            }
        }
    }
}
