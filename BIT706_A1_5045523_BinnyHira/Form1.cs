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

            EverydayAccount acc1 = new EverydayAccount();
            InvestmentAccount acc2 = new InvestmentAccount(3.99);
            OmniAccount acc3 = new OmniAccount(4.99);
            EverydayAccount acc4 = new EverydayAccount();
            InvestmentAccount acc5 = new InvestmentAccount(3.99);
            OmniAccount acc6 = new OmniAccount(4.99);
            textOutput.Items.Add(acc1.ToString());
            textOutput.Items.Add(acc2.ToString());
            textOutput.Items.Add(acc3.ToString());
            textOutput.Items.Add(acc4.ToString());
            textOutput.Items.Add(acc5.ToString());
            textOutput.Items.Add(acc6.ToString());
            //Customer cust1 = new Customer("cust1", "0210616162", "2 Roada street, Auckland", acc1);

        }
    }
}
