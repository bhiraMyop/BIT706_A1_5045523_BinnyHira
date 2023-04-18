using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class InvestmentAccount : AAccounts
    {
        // Constructors
        public InvestmentAccount(double interestRate, Customer customer) : base(interestRate, customer) 
        {//intreset rate is set at account creation
            //Failed fee is standard $10.00

        }

        // Methods
        public override void deposit(double depositAmount)
        {
            if (depositAmount > 0)
            {
                Balance += depositAmount;
            }
        }

        public override string withdrawl(AAccounts selectedAcc, double withdrawlAmount)
        {
            string str = "";
            if (withdrawlAmount > 0 && Balance >= withdrawlAmount)
            {
                Balance -= withdrawlAmount;
                str = ($"Withdrawl Completed: {selectedAcc.ToString()}");
            }
            else if (withdrawlAmount <= 0 || Balance < withdrawlAmount)
            {
               // FailedFee = 10;
                str = ($"Withdrawl Failed - Not enough Money in Account\n " +
                    $"Investment Account {AccountNo}; Withdrawl Amount {withdrawlAmount}; Transaction Failed; Fee {FailedFee};  Balance ${Balance}");
            }
            return str;
        }

        public override string ToString()
        {
            string str = $"Investment Account {AccountNo}; Balance ${Balance}";
            return str;
        }
        public override string toStringListAccounts()
        {
            string str = $"Investment Account {AccountNo}; InterestRate {InterestRate}%; Failed Fee{FailedFee};  Balance ${Balance}";
            return str;
        }
    }
}
