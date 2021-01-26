using System;
using System.Text;

namespace UnicityCalculator.Internal
{
    internal static class Bytes
    {
        private static readonly byte[] Empty
            = new byte[0];

        internal static ReadOnlySpan<byte> From(object value)
        {
            if (value is bool boolValue)
                return From(boolValue);
            if (value is byte byteValue)
                return From(byteValue);
            if (value is sbyte sbyteValue)
                return From(sbyteValue);
            if (value is short shortValue)
                return From(shortValue);
            if (value is ushort ushortValue)
                return From(ushortValue);
            if (value is int intValue)
                return From(intValue);
            if (value is uint uintValue)
                return From(uintValue);
            if (value is long longValue)
                return From(longValue);
            if (value is ulong ulongValue)
                return From(ulongValue);
            if (value is float floatValue)
                return From(floatValue);
            if (value is double doubleValue)
                return From(doubleValue);
            if (value is decimal decimalValue)
                return From(decimalValue);
            if (value is DateTime DateTimeValue)
                return From(DateTimeValue);
            if (value is TimeSpan TimeSpanValue)
                return From(TimeSpanValue);
            if (value is char charValue)
                return From(charValue);
            if (value is string stringValue)
                return From(stringValue);
            if (value is Guid GuidValue)
                return From(GuidValue);
            if (value is null)
                return Empty;

            throw new TypeNotSupportedException();
        }

        private static ReadOnlySpan<byte> From(bool value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(byte value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(sbyte value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(short value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(ushort value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(int value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(uint value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(long value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(ulong value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(float value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(double value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(decimal value)
            => BitConverter.GetBytes(Convert.ToDouble(value));

        private static ReadOnlySpan<byte> From(DateTime value)
            => BitConverter.GetBytes(value.Ticks);

        private static ReadOnlySpan<byte> From(TimeSpan value)
            => BitConverter.GetBytes(value.Ticks);

        private static ReadOnlySpan<byte> From(char value)
            => BitConverter.GetBytes(value);

        private static ReadOnlySpan<byte> From(string? value)
            => Encoding.UTF8.GetBytes(value ?? string.Empty);

        private static ReadOnlySpan<byte> From(Guid value)
            => value.ToByteArray();
    }
}
