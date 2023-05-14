using System;
using System.Runtime.Serialization;

namespace BIT706_A1_5045523_BinnyHira
{
    [Serializable]
    internal class NoAccountSelectedException : Exception
    {
        public NoAccountSelectedException()
        {
        }

        public NoAccountSelectedException(string message) : base(message)
        {
        }

        public NoAccountSelectedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoAccountSelectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}