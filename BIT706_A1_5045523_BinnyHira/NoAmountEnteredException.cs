using System;
using System.Runtime.Serialization;

namespace BIT706_A1_5045523_BinnyHira
{
    [Serializable]
    internal class NoAmountEnteredException : Exception
    {
        public NoAmountEnteredException()
        {
        }

        public NoAmountEnteredException(string message) : base(message)
        {
        }

        public NoAmountEnteredException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoAmountEnteredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}