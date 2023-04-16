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
        private bool isBanksstaff = false;
        private List<AAccounts> customerAccounts;

        //Getter and Setter
        internal List<AAccounts> CustomerAccounts { get => customerAccounts; set => customerAccounts = value; }
        public bool IsBanksstaff { get => isBanksstaff; set => isBanksstaff = value; }

        // Constructors
        // constructor for new customer

        public Customer() { }

        public Customer(string name, string contactNo, string address) : base(name, contactNo, address)
        {
        }

        // Method for when banks staff isCustomer. 
        public Customer(BankStaff bnkStaff)
        {
            IsBanksstaff = true;
            PersonID = bnkStaff.PersonID;
            Name = bnkStaff.Name;
            ContactNo = bnkStaff.ContactNo;
            Address = bnkStaff.Address.ToString();   
        }

        // Methods

        public override string ToString()
        {
            return ($"{PersonID.ToString()}  {Name.ToString()} {ContactNo.ToString()} {Address.ToString()} {isBanksstaff.ToString()}");
        }

    }
}
