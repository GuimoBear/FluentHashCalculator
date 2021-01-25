namespace UnicityCalculator
{
    using UnicityCalculator.Internal;
    using System;
    using System.IO;
    using System.Text;

    internal class UnicityCalculatorBuilder : IDisposable
    {
        private bool disposed = false;

        private readonly MemoryStream bytes
            = new MemoryStream();

        internal UnicityCalculatorBuilder() { }

        internal UnicityCalculatorBuilder With(object value)
        {
            if (value is bool boolValue)
                return With(boolValue);
            if (value is byte byteValue)
                return With(byteValue);
            if (value is sbyte sbyteValue)
                return With(sbyteValue);
            if (value is short shortValue)
                return With(shortValue);
            if (value is ushort ushortValue)
                return With(ushortValue);
            if (value is int intValue)
                return With(intValue);
            if (value is uint uintValue)
                return With(uintValue);
            if (value is long longValue)
                return With(longValue);
            if (value is ulong ulongValue)
                return With(ulongValue);
            if (value is float floatValue)
                return With(floatValue);
            if (value is double doubleValue)
                return With(doubleValue);
            if (value is decimal decimalValue)
                return With(decimalValue);
            if (value is DateTime DateTimeValue)
                return With(DateTimeValue);
            if (value is TimeSpan TimeSpanValue)
                return With(TimeSpanValue);
            if (value is char charValue)
                return With(charValue);
            if (value is string stringValue)
                return With(stringValue);
            if (value is Guid GuidValue)
                return With(GuidValue);
            if (value is null)
            {
                if (disposed)
                    throw new ObjectDisposedException("builder");
                return this;
            }

            throw new TypeNotSupportedException();
        }

        private UnicityCalculatorBuilder With(bool value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(byte value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(sbyte value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(short value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(ushort value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(int value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(uint value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(long value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(ulong value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(float value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(double value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(decimal value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(Convert.ToDouble(value)));
            return this;
        }

        private UnicityCalculatorBuilder With(DateTime value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value.Ticks));
            return this;
        }

        private UnicityCalculatorBuilder With(TimeSpan value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value.Ticks));
            return this;
        }

        private UnicityCalculatorBuilder With(char value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(BitConverter.GetBytes(value));
            return this;
        }

        private UnicityCalculatorBuilder With(string? value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(Encoding.UTF8.GetBytes(value ?? string.Empty));
            return this;
        }

        private UnicityCalculatorBuilder With(Guid value)
        {
            if (disposed)
                throw new ObjectDisposedException("builder");
            bytes.Write(value.ToByteArray());
            return this;
        }

        internal ulong Build()
        {
            return Crc64.Compute(bytes.ToArray());
        }

        public void Dispose()
        {
            bytes.Dispose();
            disposed = true;
        }
    }
}
