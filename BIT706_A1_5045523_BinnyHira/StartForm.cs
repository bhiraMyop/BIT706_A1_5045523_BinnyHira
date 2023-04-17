using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A1_5045523_BinnyHira
{
    public partial class StartForm : ParentForm
    {
        /*
        //List of all customers
        private List<Customer> allcustomers = new List<Customer>();
        private List<AAccounts> allAccounts = new List<AAccounts>();

        internal List<Customer> Allcustomers { get => allcustomers; set => allcustomers = value; }
        internal List<AAccounts> AllAccounts { get => allAccounts; set => allAccounts = value; }
        */
        public StartForm()
        {
            InitializeComponent();
            if (Allcustomers.Count == 0)
            {
                initializeOjects();

            }
            DisplayCustomers();
        }
        public void initializeOjects()
        {

            {
                BankStaff staff1 = new BankStaff("staff1", "0210616161", "1 Roada street, Auckland");
                BankStaff staff2 = new BankStaff("staff2", "0210616162", "2 Roada street, Auckland");
                Customer cust1 = new Customer(staff2); //  bankstaff is a customer
                Customer cust2 = new Customer("cust2", "0210616163", "31 Roada street, Auckland");
                Customer cust3 = new Customer("cust3", "0210610003", "3 Roada street, Auckland");
                Customer cust4 = new Customer("cust4", "0210616164", "4 Roada street, Auckland");
                Customer cust5 = new Customer("cust5", "0210616165", "5 Roada street, Auckland");
                Customer cust6 = new Customer(staff1);

                Allcustomers.Add(cust1);
                Allcustomers.Add(cust2);
                Allcustomers.Add(cust3);
                Allcustomers.Add(cust4);
                Allcustomers.Add(cust5);
                Allcustomers.Add(cust6);

                EverydayAccount acc1 = new EverydayAccount(cust1);
                InvestmentAccount acc2 = new InvestmentAccount(3.99, cust1);
                OmniAccount acc3 = new OmniAccount(4.99, cust1, 100);
                EverydayAccount acc4 = new EverydayAccount(cust1);
                InvestmentAccount acc5 = new InvestmentAccount(2.99, cust5);
                OmniAccount acc6 = new OmniAccount(5.99, cust6, 200);

                //add all accounts to list of accounts

                AllAccounts.Add(acc1);
                AllAccounts.Add(acc2);
                AllAccounts.Add(acc3);
                AllAccounts.Add(acc4);
                AllAccounts.Add(acc5);
                AllAccounts.Add(acc6);

                acc1.deposit(100);
                acc2.deposit(200);
                acc3.deposit(300);
                acc4.deposit(400);
                acc5.deposit(500);
                acc6.deposit(600);

                acc1.withdrawl(50);
                acc2.withdrawl(-50);
                acc3.withdrawl(50);
                acc4.withdrawl(50);
                acc5.withdrawl(50);
                acc6.withdrawl(50);
            }
        }

        public void DisplayCustomers()
        {
            //make sure listbox is empty
            lstCustomers.Items.Clear();
            //Add the book titles to the listBox
            foreach (Customer cust in Allcustomers)
            {
                lstCustomers.Items.Add(cust);
            }
            //Select the first item
            lstCustomers.SelectedIndex = 0;
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            SelectedCust = (Customer)lstCustomers.SelectedItem;
            lblInfo.Text = SelectedCust.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
            lblInfo.Text = "";
            SelectedCust = null; // Clear selection.
        }

        private void openAccountsButton_Click(object sender, EventArgs e)
        {
            
            if (SelectedCust != null)
            {
                
                ShowAccounts showAccounts = new ShowAccounts();
                ActiveForm.Hide();
                showAccounts.Show();
            }
            else 
            {
                MessageBox.Show("ERROR! - No Customer Selected.");
            }

        }
    }
}
