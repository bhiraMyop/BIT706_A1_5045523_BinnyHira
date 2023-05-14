using System;
using System.Runtime.Serialization;

namespace BIT706_A1_5045523_BinnyHira
{
    [Serializable]
    internal class NotEnoughMoneyInAccountException : Exception
    {
        public NotEnoughMoneyInAccountException()
        {
        }

        public NotEnoughMoneyInAccountException(string message) : base(message)
        {
        }

        public NotEnoughMoneyInAccountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughMoneyInAccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}