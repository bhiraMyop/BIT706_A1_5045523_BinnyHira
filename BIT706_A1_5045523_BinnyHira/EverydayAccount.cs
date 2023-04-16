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
        public EverydayAccount(Customer customer) : base(customer) { }


        // Methods
        public override void deposit(double depositAmount)
        {
            Balance += depositAmount;
        }

        public override string withdrawl()
        {
            return "";
        }

        /*
        public override string ToString()
        {
            return ($"Account Type = Everyday Account " +
                $"\nAccountNo =  {AccountNo.ToString()} " +
                $"\nBalance = ${Balance.ToString()} " +
                $"\nFailedFee = {FailedFee.ToString()} " +
                $"\nInterestRate = {InterestRate.ToString()} " +
                $"\nOverdraft Allowed = {Overdraft.ToString()} " +
                $"\nCustomers Details {Customer.Name}");
        }
        */
        public override string ToString()
        {
            return ($"Account Type = Everyday Account " +
                $"\nCustomers Details {Customer.Name} {Customer.Address}");
        }
    }
}
