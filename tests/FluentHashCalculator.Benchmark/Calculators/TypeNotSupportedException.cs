using System;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public class TypeNotSupportedException : Exception
    {
        private const string MESSAGE = "Only bool, bool?, byte, byte?, sbyte, sbyte?, short, short?, ushort, ushort?, int, int?, uint, uint?, long, long?, ulong, ulong?, float, float?, double, double?, decimal, decimal?, DateTime, DateTime?, TimeSpan, TimeSpan?, char, char?, string, Guid, Guid? and the lists from this types are acceptable to calculate the Hash";

        public TypeNotSupportedException()
            : base(MESSAGE)
        {

        }
    }
}
