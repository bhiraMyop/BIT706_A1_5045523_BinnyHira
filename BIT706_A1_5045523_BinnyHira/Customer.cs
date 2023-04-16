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
        private List<Object> customerAccounts;

        //Getter and Setter
        internal List<Object> CustomerAccounts { get => customerAccounts; set => customerAccounts = value; }

        // Constructors
        // constructor for new customer
        public Customer(string name, string contactNo, string address, List<Object> customerAccounts) : base(name, contactNo, address)
        {
            CustomerAccounts = customerAccounts;
        }
        // Methods

    }
}
