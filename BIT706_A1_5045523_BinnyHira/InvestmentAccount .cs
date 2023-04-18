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
        public override string deposit(AAccounts selectedAcc, double depositAmount)
        {
            string str = "";
            if (depositAmount <= 0)
            {
                str = ("Deposit Failed - Amount cannot be less that or equal to 0");
            }
            else if(depositAmount > 0)
            {
                Balance += depositAmount;
                str = ($"Everyday Account {AccountNo}; Deposit Amount {depositAmount}; Balance ${Balance}");
            }
            return str;
        }

        public override string withdrawl(AAccounts selectedAcc, double withdrawlAmount)
        {
            string str = "";
            if (withdrawlAmount > 0 && Balance >= withdrawlAmount)
            {
                Balance -= withdrawlAmount;
                str = ($"Withdrawl Completed: {selectedAcc.ToString()}");
            }
            else if (withdrawlAmount <= 0)
            {
                str = ("Withdrawl Failed - Amount cannot be less that or equal to 0");
            }
            else if (Balance < withdrawlAmount)
            {
               // FailedFee = 10;
                str = ($"Withdrawl Failed - Not enough Money in Account\n " +
                    $"Investment Account {AccountNo}; Withdrawl Amount {withdrawlAmount}; Transaction Failed; Fee {FailedFee};  Balance ${Balance}");
            }
            return str;
        }

        public override string calculateInterest(AAccounts selectedAcc, double depositAmount)
        {
            string str = "";
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
