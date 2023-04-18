using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class OmniAccount : AAccounts
    {
        // Constructors
        public OmniAccount(double interestRate, Customer customer, double overdraftLimit) : base(interestRate, customer, overdraftLimit)
        {
            //intreset rate is set at account creation
            //Failed fee is standard $10.00
            Overdraft = (int)OverdraftAllowed.Yes;
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
            if (withdrawlAmount > 0 && (Balance+OverdraftLimit) >= withdrawlAmount)
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
                //FailedFee = 10;
                Balance -= FailedFee;
                str = ($"Withdrawl Failed - Not enough Money in Account\n " +
                    $"Omni Account {AccountNo}; Withdrawl Amount {withdrawlAmount}; " +
                    $"Transaction Failed; Fee {FailedFee}; Overdraft Limit {OverdraftLimit}; Balance ${Balance}");
            }
            return str;
        }

        public override string calculateInterest(AAccounts selectedAcc)
        {
            string str = "";
            if (selectedAcc.Balance >= 1000.00)
            {
                Balance += (selectedAcc.InterestRate / 100) * selectedAcc.Balance;
                str = $"Omni Account {AccountNo}; InterestRate {InterestRate}%; Balance ${Balance}";
            }
            else
            {
                str = "Intrest Update Failed!!!! - Account does not have a balance over $1000";
            }
            return str;
        }

        public override string ToString()
        {
            string str = $"Omni Account {AccountNo}; Balance ${Balance}";

            return str;
        }
        public override string toStringListAccounts()
        {
            string str = $"Omni Account {AccountNo}; InterestRate {InterestRate}%; Overdraft Limit ${OverdraftLimit}; " +
                $"Failed Fee{FailedFee};  Balance ${Balance}";
            return str;
        }
    }
}
