using System;
using System.Runtime.Serialization;

namespace BIT706_A1_5045523_BinnyHira
{
    [Serializable]
    internal class StringEnteredException : Exception
    {
        public StringEnteredException()
        {
        }

        public StringEnteredException(string message) : base(message)
        {
        }

        public StringEnteredException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringEnteredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}