using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class Customer : APerson
    {
        //ID is inherited from Person Class
        //public int customerIDCounter = 1;
        //public int customerID;
        private List<IAccounts> customerAccounts;

        //Getter and Setter
        internal List<IAccounts> CustomerAccounts { get => customerAccounts; set => customerAccounts = value; }

        // Getter and Setter
        // Constructors
        public Customer(string name, string contactNo, string address, List<IAccounts> customerAccounts) : base(name, contactNo, address)
        {
            this.customerAccounts = customerAccounts;
        }
        // Methods
        public void withdrawl(){ }
        // Deposit Method
        public void deposit(){ }
        // Withdrawal Method
    }
}
