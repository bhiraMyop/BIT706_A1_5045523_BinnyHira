using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5045523_BinnyHira
{
    internal abstract class AAccounts
    {
        private int accountNo;
        static int accountCounter = 1;
        private double balance = 0;
        private double failedFee = 0.0;
        private double interestRate = 0.0; //in percentage 0.0%
        private int overdraft = (int)OverdraftAllowed.No;


        // Getter and Setter
        public int AccountNo { get => accountNo; set => accountNo = value; }
        public double Balance { get => balance; set => balance = value; }
        public double FailedFee { get => failedFee; set => failedFee = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        internal int Overdraft { get => overdraft; set => overdraft = value; }


        // Constructors
        public AAccounts()
        {
            AccountNo = accountCounter;
            accountCounter++;
        }
        //for Investment Account and Omni Accounts
        public AAccounts(double interestRate) : this()
        { 
            InterestRate = interestRate;
            FailedFee = 10.00;
        }

        // Withdrawal Method
        public abstract string withdrawl();
        // Deposit Method
        public abstract string deposit();

        public override string ToString()
        {
            return ($"AccountNo = +  {AccountNo.ToString()} " +
                $"\nBalance = {Balance.ToString()} " +
                $"\nFailedFee = {FailedFee.ToString()} " +
                $"\nInterestRate = {InterestRate.ToString()} " +
                $"\nOverdraft Allowed = {Overdraft.ToString()} ");
        }
    }
}
