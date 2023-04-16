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
    public partial class StartForm : Form
    {
        //List of all customers
        List<Customer> allcustomers = new List<Customer>();
        List<AAccounts> allAccounts = new List<AAccounts>();

        public StartForm()
        {
            InitializeComponent();
            initializeOjects();
            DisplayCustomers();
        }
        public void initializeOjects()
        {
            BankStaff staff1 = new BankStaff("staff1", "0210616161", "1 Roada street, Auckland");
            BankStaff staff2 = new BankStaff("staff2", "0210616162", "2 Roada street, Auckland");
            Customer cust1 = new Customer(staff2); //  bankstaff is a customer
            Customer cust2 = new Customer("cust2", "0210616163", "31 Roada street, Auckland");
            Customer cust3 = new Customer("cust3", "0210610003", "3 Roada street, Auckland");
            Customer cust4 = new Customer("cust4", "0210616164", "4 Roada street, Auckland");
            Customer cust5 = new Customer("cust5", "0210616165", "5 Roada street, Auckland");
            Customer cust6 = new Customer(staff1);

            allcustomers.Add(cust1);
            allcustomers.Add(cust2);
            allcustomers.Add(cust3);
            allcustomers.Add(cust4);
            allcustomers.Add(cust5);
            allcustomers.Add(cust6);

            EverydayAccount acc1 = new EverydayAccount(cust1);
            InvestmentAccount acc2 = new InvestmentAccount(3.99, cust2);
            OmniAccount acc3 = new OmniAccount(4.99, cust3);
            EverydayAccount acc4 = new EverydayAccount(cust4);
            InvestmentAccount acc5 = new InvestmentAccount(3.99, cust5);
            OmniAccount acc6 = new OmniAccount(4.99, cust6);

            //add all accounts to list of accounts

            allAccounts.Add(acc1);
            allAccounts.Add(acc2);
            allAccounts.Add(acc3);
            allAccounts.Add(acc4);
            allAccounts.Add(acc5);
            allAccounts.Add(acc6);

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

        public void DisplayCustomers()
        {
            //make sure listbox is empty
            lstCustomers.Items.Clear();
            //Add the book titles to the listBox
            foreach (Customer cust in allcustomers)
            {
                lstCustomers.Items.Add(cust);
            }
            //Select the first item
            lstCustomers.SelectedIndex = 0;
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)lstCustomers.SelectedItem;
            lblInfo.Text = selectedCustomer.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
            lblInfo.Text = "";
        }

    }
}
