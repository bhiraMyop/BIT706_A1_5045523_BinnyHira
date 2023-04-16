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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            /// Try the code here
            /// 


            BankStaff staff1 = new BankStaff("staff1", "0210616161", "1 Roada street, Auckland");
            textOutput.Items.Add(staff1.ToString());
            BankStaff staff2 = new BankStaff("staff2", "0210616162", "2 Roada street, Auckland");
            textOutput.Items.Add(staff2.ToString());


            Customer cust1 = new Customer(staff2); //  bankstaff is a customer
            textOutput.Items.Add(cust1.ToString());
            textOutput.Items.Add("");
            Customer cust2 = new Customer("cust2", "0210616163", "31 Roada street, Auckland");
            Customer cust3 = new Customer("cust3", "0210610003", "3 Roada street, Auckland");
            Customer cust4 = new Customer("cust4", "0210616164", "4 Roada street, Auckland");
            Customer cust5 = new Customer("cust5", "0210616165", "5 Roada street, Auckland");

            EverydayAccount acc1 = new EverydayAccount(cust1);
            InvestmentAccount acc2 = new InvestmentAccount(3.99, cust2);
            OmniAccount acc3 = new OmniAccount(4.99, cust2);
            EverydayAccount acc4 = new EverydayAccount(cust3);
            InvestmentAccount acc5 = new InvestmentAccount(3.99, cust4);
            OmniAccount acc6 = new OmniAccount(4.99, cust5);


            acc1.deposit(100);
            acc2.deposit(200);
            acc3.deposit(-300);

            textOutput.Items.Add(acc1.ToString());
            textOutput.Items.Add(acc2.ToString());
            textOutput.Items.Add(acc3.ToString());
            textOutput.Items.Add(acc4.ToString());
            textOutput.Items.Add(acc5.ToString());
            textOutput.Items.Add(acc6.ToString());

        }
    }
}
