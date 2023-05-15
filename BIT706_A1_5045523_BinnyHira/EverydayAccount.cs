using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public override string deposit(AAccounts selectedAcc, double depositAmount)
        {
            string str = "";
            if(depositAmount <= 0)
            {
                str = ("Deposit Failed - Amount cannot be less that or equal to 0");
            }
            else if (depositAmount > 0)
            {
                Balance += depositAmount;
                str = ($"Everyday Account {AccountNo}; Deposit Amount {depositAmount}; Balance ${Balance}");
            }
            return str;
        }
         
        public override string withdrawal(AAccounts selectedAcc, double withdrawlAmount)
        {
            string str = "";
            try
            {
                if (withdrawlAmount <= 0)
                {
                    throw new WithdrawalAmountIs0OrLessExpection("withdrawal Failed - Amount cannot be less that or equal to 0");
                }
                else if (Balance < withdrawlAmount)
                {
                    //FailedFee = 0;
                    Balance -= FailedFee;
                    throw new NotEnoughMoneyInAccountException($"withdrawal Failed - Not enough Money in Account\n" +
                    $"Everyday Account {AccountNo}; withdrawal Amount {withdrawlAmount}; Transaction Failed; Fee {FailedFee};  " +
                    $"Balance ${Balance}");
                }
                else
                {
                    Balance -= withdrawlAmount;
                    str = ($"withdrawal Completed: {selectedAcc.ToString()}");
                }
            }
            catch(Exception) { throw; } //throwing the exception to ShowAccounts form.
            return str;

            /*
            if (withdrawlAmount > 0 && Balance >= withdrawlAmount )
            {
                Balance -= withdrawlAmount;
                str = ($"Withdrawl Completed: {selectedAcc.ToString()}");
            }
            else if(withdrawalAmount <= 0)
            {
                str = ("Withdrawal Failed - Amount cannot be less that or equal to 0");
            }
            else if ( Balance < withdrawalAmount)
            {
                //FailedFee = 0;
                Balance -= FailedFee;
                str = ($"Withdrawl Failed - Not enough Money in Account\n" +
                    $"Everyday Account {AccountNo}; Withdrawl Amount {withdrawlAmount}; Transaction Failed; Fee {FailedFee};  " +
                    $"Balance ${Balance}");
            }
            return str;
            */
        }

        public override string calculateInterest(AAccounts selectedAcc)
        {
            string str = "Intereset Rates do no Apply on this account.";
            return str;
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
