using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class BankStaff : APerson
    {
        private Customer isCustomer;

       //Getter and Setters
        internal Customer IsCustomer { get => isCustomer; set => isCustomer = value; }

        // Constructors
        public BankStaff(string name, string contactNo, string address) : base(name, contactNo, address)
        {
           // Default constructor for Banks staff only.
        }
        public BankStaff(string name, string contactNo, string address, Customer isCustomer) : base(name, contactNo, address) 
        { //Constructor for when the staff is also a customer. 
            IsCustomer = isCustomer;
        }

    }
}
