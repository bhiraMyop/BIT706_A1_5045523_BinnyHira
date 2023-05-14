using System;
using System.Runtime.Serialization;

namespace BIT706_A1_5045523_BinnyHira
{
    [Serializable]
    internal class WithdrawalAmountIs0OrLessExpection : Exception
    {
        public WithdrawalAmountIs0OrLessExpection()
        {
        }

        public WithdrawalAmountIs0OrLessExpection(string message) : base(message)
        {
        }

        public WithdrawalAmountIs0OrLessExpection(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WithdrawalAmountIs0OrLessExpection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}