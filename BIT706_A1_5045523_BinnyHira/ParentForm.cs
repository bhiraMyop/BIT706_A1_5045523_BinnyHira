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
    public partial class ParentForm : Form
    {
        //List of all customers
        private static List<Customer> allcustomers = new List<Customer>();
        private static List<AAccounts> allAccounts = new List<AAccounts>();
        private static int custID;
        private static int accID;
        private static Customer selectedCust = null;
        private static AAccounts selectedAcc = null;

       public static int CustID { get => custID; set => custID = value; }
        public static int AccID { get => accID; set => accID = value; }
        internal static List<Customer> Allcustomers { get => allcustomers; set => allcustomers = value; }
        internal static List<AAccounts> AllAccounts { get => allAccounts; set => allAccounts = value; }
        internal static Customer SelectedCust { get => selectedCust; set => selectedCust = value; }
        internal static AAccounts SelectedAcc { get => selectedAcc; set => selectedAcc = value; }

        public ParentForm()
        {
            InitializeComponent();
        }

    }
}
