using System;

namespace UnicityCalculator
{
    public class TypeNotSupportedException : Exception
    {
        private const string MESSAGE = "Only bool, bool?, byte, byte?, sbyte, sbyte?, short, short?, ushort, ushort?, int, int?, uint, uint?, long, long?, ulong, ulong?, float, float?, double, double?, decimal, decimal?, DateTime, DateTime?, TimeSpan, TimeSpan?, char, char?, string?, Guid and Guid? types are acceptable to calculate CRC32";

        public TypeNotSupportedException()
            : base(MESSAGE)
        {

        }
    }
}
