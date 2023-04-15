using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class OmniAccount : IAccounts
    {
        private int accountNo;
        private int everydayAccCounter = 1;
        private double balance;
        private double failedFee = 0.0; //in percentage 0.0%
        private double interestRate = 0.0; //in percentage 0.0%
        private int overdraft = 0;

        // Getter and Setter
        public int AccountNo { get => accountNo; set => accountNo = value; }
        public double Balance { get => balance; set => balance = value; }
        public double FailedFee { get => failedFee; set => failedFee = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        internal int Overdraft { get => overdraft; } // no need for setter as the account is not allowed Overdraft and the default value is set to 0.

        // Constructors
        public OmniAccount()
        {
            AccountNo = everydayAccCounter;
            everydayAccCounter++;
            
            // Set failed fee
            // FailedFee fee is the same for all accounts
            FailedFee = 10.00;
        }

        public OmniAccount(double balance) : this()
        {
            Balance = balance;
        }
        /*
        public InvestmentAccount(double balance, double failedFee) : this(balance)
        {
            FailedFee = failedFee;
        }*/

        public OmniAccount(double balance, double interestRate) : this(balance) // intrest rate is set at account creation
        {
            InterestRate = interestRate;
        }


        // Methods
        // Deposit Method
        public void deposit()
        {
            throw new NotImplementedException();
        }
        // Withdrawal Method
        public void withdrawl()
        {
            throw new NotImplementedException();
        }
    }
}
