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
                    lstAccounts.Items.Add(acc.AccountNo.ToString());
                }
                else { lstAccounts.Items.Add("No Accounts found"); }
            }
            
            //Select the first item
            lstAccounts.SelectedIndex = 0;
        }
    }
}
