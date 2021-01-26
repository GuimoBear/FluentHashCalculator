using System;

namespace FluentHashCalculator
{
    public class CrcException : Exception
    {
        public CrcException(string message, FormatException innerException)
            : base(message, innerException)
        {

        }

        public CrcException(string message, InvalidCastException innerException)
            : base(message, innerException)
        {

        }
        public CrcException(string message, OverflowException innerException)
            : base(message, innerException)
        {

        }
    }
}
