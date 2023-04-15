﻿using System;
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
        // Getter and Setter
        public int AccountNo { get => accountNo; set => accountNo = value; }
        public double Balance { get => balance; set => balance = value; }
        internal int Overdraft { get => overdraft; } // no need for setter as the account is not allowed Overdraft and the default value is set to 0.
        
        // Constructors
        public EverydayAccount()
        {
            AccountNo = everydayAccCounter;
            everydayAccCounter++;
        }

        public EverydayAccount(double balance) : this()
        {
            Balance = balance;
        }

        // Methods
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
