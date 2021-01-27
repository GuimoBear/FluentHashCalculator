using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FluentHashCalculator.Internal
{
    internal static class Bytes
    {
        public static readonly byte[] Empty = new byte[0];

        internal static IEnumerable<byte[]> From(object value, bool supressExpection = false)
        {
            if (value is bool boolValue)
            {
                yield return From(boolValue);
                yield break;
            }
            else if (value is byte byteValue)
            { 
                yield return From(byteValue);
                yield break;
            }
            else if (value is sbyte sbyteValue)
            { 
                yield return From(sbyteValue);
                yield break;
            }
            else if (value is short shortValue)
            { 
                yield return From(shortValue);
                yield break;
            }
            else if (value is ushort ushortValue)
            { 
                yield return From(ushortValue);
                yield break;
            }
            else if (value is int intValue)
            { 
                yield return From(intValue);
                yield break;
            }
            else if (value is uint uintValue)
            { 
                yield return From(uintValue);
                yield break;
            }
            else if (value is long longValue)
            { 
                yield return From(longValue);
                yield break;
            }
            else if (value is ulong ulongValue)
            { 
                yield return From(ulongValue);
                yield break;
            }
            else if (value is float floatValue)
            { 
                yield return From(floatValue);
                yield break;
            }
            else if (value is double doubleValue)
            { 
                yield return From(doubleValue);
                yield break;
            }
            else if (value is decimal decimalValue)
            { 
                yield return From(decimalValue);
                yield break;
            }
            else if (value is DateTime DateTimeValue)
            { 
                yield return From(DateTimeValue);
                yield break;
            }
            else if (value is TimeSpan TimeSpanValue)
            { 
                yield return From(TimeSpanValue);
                yield break;
            }
            else if (value is char charValue)
            { 
                yield return From(charValue);
                yield break;
            }
            else if (value is string stringValue)
            { 
                yield return From(stringValue);
                yield break;
            }
            else if (value is Guid GuidValue)
            { 
                yield return From(GuidValue);
                yield break;
            }
            else if (value is IEnumerable listValue)
            { 
                foreach (var item in From(listValue))
                    yield return item;
                yield break;
            }
            else if (value is null || supressExpection)
                yield break;
            else 
                throw new TypeNotSupportedException();
        }

        private static IEnumerable<byte[]> From(IEnumerable values)
        {
            foreach (var value in values)
                foreach (var item in From(value, true))
                    yield return item;
        }

        private static byte[] From(bool value)
            => BitConverter.GetBytes(value);

        private static byte[] From(byte value)
            => BitConverter.GetBytes(value);

        private static byte[] From(sbyte value)
            => BitConverter.GetBytes(value);

        private static byte[] From(short value)
            => BitConverter.GetBytes(value);

        private static byte[] From(ushort value)
            => BitConverter.GetBytes(value);

        private static byte[] From(int value)
            => BitConverter.GetBytes(value);

        private static byte[] From(uint value)
            => BitConverter.GetBytes(value);

        private static byte[] From(long value)
            => BitConverter.GetBytes(value);

        private static byte[] From(ulong value)
            => BitConverter.GetBytes(value);

        private static byte[] From(float value)
            => BitConverter.GetBytes(value);

        private static byte[] From(double value)
            => BitConverter.GetBytes(value);

        private static byte[] From(decimal value)
            => BitConverter.GetBytes(Convert.ToDouble(value));

        private static byte[] From(DateTime value)
            => BitConverter.GetBytes(value.Ticks);

        private static byte[] From(TimeSpan value)
            => BitConverter.GetBytes(value.Ticks);

        private static byte[] From(char value)
            => BitConverter.GetBytes(value);

        private static byte[] From(string? value)
            => Encoding.UTF8.GetBytes(value ?? string.Empty);

        private static byte[] From(Guid value)
            => value.ToByteArray();
    }
}
