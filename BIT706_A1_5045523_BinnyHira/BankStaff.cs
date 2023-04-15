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
       //ID is inherited from Person Class
       // public int bankIDCounter = 1;
       //private int bankStaffID;
        private Customer isCustomer;

       // public int BankStaffID { get => bankStaffID; set => bankStaffID = value; }
        internal Customer IsCustomer { get => isCustomer; set => isCustomer = value; }

        public BankStaff()
        {
       //     bankStaffID = bankIDCounter;
       //     bankIDCounter++;
        }

        public BankStaff(Customer isCustomer) : this() 
        {
            IsCustomer = isCustomer;
        }




    }
}
