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

        public override string Withdrawal(AAccounts selectedAcc, double withdrawlAmount)
        {
            string str = "";
            try
            {
                if (withdrawlAmount <= 0)
                {
                    throw new WithdrawalAmountIs0OrLessExpection("Withdrawal Failed - Amount cannot be less that or equal to 0");
                }
                else if (Balance < withdrawlAmount)
                {
                    //FailedFee = 10;
                    Balance -= FailedFee;
                    throw new NotEnoughMoneyInAccountException($"Withdrawal Failed - Not enough Money in Account\n" +
                    $"Everyday Account {AccountNo}; Withdrawal Amount {withdrawlAmount}; Transaction Failed; Fee {FailedFee};  " +
                    $"Balance ${Balance}");
                }
                else
                {
                    Balance -= withdrawlAmount;
                    str = ($"Withdrawal Completed: {selectedAcc.ToString()}");
                }
            }
            catch (Exception) { throw; } //throwing the exception to ShowAccounts form.
            return str;

            /*
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
                Balance -= FailedFee;
                str = ($"Withdrawl Failed - Not enough Money in Account\n" +
                    $"Investment Account {AccountNo}; Withdrawl Amount {withdrawlAmount}; Transaction Failed; Fee {FailedFee};  " +
                    $"Balance ${Balance}");
            }
            return str;*/
        }

        public override string calculateInterest(AAccounts selectedAcc)
        {
            string str = "";
            Balance += (selectedAcc.InterestRate / 100) * selectedAcc.Balance;
            str = $"Investment Account {AccountNo}; InterestRate {InterestRate}%; Balance ${Balance}";
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
