using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5045523_BinnyHira
{
    internal class EverydayAccount : IAccounts
    {
        private int accountNo;
        private int everydayAccCounter = 1;
        private double balance;
        private int overdraft = 0;
        
        public int AccountNo { get => accountNo; set => accountNo = value; }
        public double Balance { get => balance; set => balance = value; }
        internal int Overdraft { get => overdraft; set => overdraft = value; }

        public EverydayAccount()
        {
            AccountNo = everydayAccCounter;
            everydayAccCounter++;
        }

        public EverydayAccount(double balance) : this()
        {
            Balance = balance;
        }

        public EverydayAccount(double balance, int overdraft) : this(balance)
        {
            Balance = balance;
            if (overdraft == 1)
            {
                Overdraft = 1;
            }
        }


        public void deposit()
        {
            throw new NotImplementedException();
        }

        public void withdrawl()
        {
            throw new NotImplementedException();
        }
    }
}
