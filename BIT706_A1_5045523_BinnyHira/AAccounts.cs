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
        private Customer customer;
        //TO hold the accounts that have been opened. 

        // Getter and Setter
        public int AccountNo { get => accountNo; set => accountNo = value; }
        public double Balance { get => balance; set => balance = value; }
        public double FailedFee { get => failedFee; set => failedFee = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        internal int Overdraft { get => overdraft; set => overdraft = value; }
        internal Customer Customer { get => customer; set => customer = value; }


        // Constructors
        public AAccounts()
        {
            AccountNo = accountCounter;
            accountCounter++;
        }
        //for everyday account
        public AAccounts(Customer customer) : this()
        {
            Customer = customer;
        }
        //for Investment Account and Omni Accounts
        public AAccounts(double interestRate) : this()
        { 
            InterestRate = interestRate;
            FailedFee = 10.00;
        }

        public AAccounts(double interestRate, Customer customer) : this(interestRate)
        {
            Customer = customer;
        }


        // Withdrawal Method
        public abstract void withdrawl(double withdrawlAmount);
        // Deposit Method
        public abstract void deposit(double depositAmount);
        
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
