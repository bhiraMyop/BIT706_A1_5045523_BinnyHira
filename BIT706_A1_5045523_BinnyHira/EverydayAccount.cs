using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class EverydayAccount : AAccounts
    {
        // Constructors
        public EverydayAccount(Customer customer) : base(customer) 
        {
            //Customer.CustomerAccounts.Add(this);
        }


        // Methods
        public override void deposit(double depositAmount)
        {
            if (depositAmount > 0)
            {
                Balance += depositAmount;
            }
        }

        public override void withdrawl(double withdrawlAmount)
        {
            if (withdrawlAmount > 0 && Balance >= withdrawlAmount )
            {
                Balance -= withdrawlAmount;
            }
            else if (withdrawlAmount <= 0 || Balance < withdrawlAmount)
            {
                FailedFee = 0;
            }
        }

        public override string ToString()
        {
            string str = $"Everyday Account {AccountNo}; Balance ${Balance}"; 
            return str;
        }

        public override string toStringListAccounts()
        {
            string str = $"Everyday Account {AccountNo}; Balance ${Balance}";
            return str;
        }
    }
}
