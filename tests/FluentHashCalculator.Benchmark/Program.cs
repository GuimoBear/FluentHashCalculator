using System;
using FluentHashCalculator.Tests;

namespace FluentHashCalculator.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var crc32test = new CRC32FluentHashCalculatorTests();

            Console.WriteLine($"        public const uint BOOL_CRC32 = {crc32test.UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_BOOL_CRC32 = {crc32test.UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC32()};");
            Console.WriteLine($"        public const uint BYTE_CRC32 = {crc32test.UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_BYTE_CRC32 = {crc32test.UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC32()};");
            Console.WriteLine($"        public const uint SBYTE_CRC32 = {crc32test.UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_SBYTE_CRC32 = {crc32test.UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC32()};");
            Console.WriteLine($"        public const uint SHORT_CRC32 = {crc32test.UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_SHORT_CRC32 = {crc32test.UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC32()};");
            Console.WriteLine($"        public const uint USHORT_CRC32 = {crc32test.UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_USHORT_CRC32 = {crc32test.UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC32()};");
            Console.WriteLine($"        public const uint INT_CRC32 = {crc32test.UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_INT_CRC32 = {crc32test.UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC32()};");
            Console.WriteLine($"        public const uint UINT_CRC32 = {crc32test.UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_UINT_CRC32 = {crc32test.UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC32()};");
            Console.WriteLine($"        public const uint LONG_CRC32 = {crc32test.UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_LONG_CRC32 = {crc32test.UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC32()};");
            Console.WriteLine($"        public const uint ULONG_CRC32 = {crc32test.UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_ULONG_CRC32 = {crc32test.UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC32()};");
            Console.WriteLine($"        public const uint FLOAT_CRC32 = {crc32test.UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_FLOAT_CRC32 = {crc32test.UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC32()};");
            Console.WriteLine($"        public const uint DOUBLE_CRC32 = {crc32test.UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_DOUBLE_CRC32 = {crc32test.UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC32()};");
            Console.WriteLine($"        public const uint DECIMAL_CRC32 = {crc32test.UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_DECIMAL_CRC32 = {crc32test.UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC32()};");
            Console.WriteLine($"        public const uint DATETIME_CRC32 = {crc32test.UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_DATETIME_CRC32 = {crc32test.UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC32()};");
            Console.WriteLine($"        public const uint TIMESPAN_CRC32 = {crc32test.UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_TIMESPAN_CRC32 = {crc32test.UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC32()};");
            Console.WriteLine($"        public const uint CHAR_CRC32 = {crc32test.UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_CHAR_CRC32 = {crc32test.UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_STRING_CRC32 = {crc32test.UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC32()};");
            Console.WriteLine($"        public const uint GUID_CRC32 = {crc32test.UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC32()};");
            Console.WriteLine($"        public const uint NULLABLE_GUID_CRC32 = {crc32test.UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC32()};");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");



            var crc16test = new CRC16FluentHashCalculatorTests();


            Console.WriteLine($"        public const uint BOOL_CRC16 = {crc16test.UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_BOOL_CRC16 = {crc16test.UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC16()};");
            Console.WriteLine($"        public const uint BYTE_CRC16 = {crc16test.UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_BYTE_CRC16 = {crc16test.UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC16()};");
            Console.WriteLine($"        public const uint SBYTE_CRC16 = {crc16test.UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_SBYTE_CRC16 = {crc16test.UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC16()};");
            Console.WriteLine($"        public const uint SHORT_CRC16 = {crc16test.UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_SHORT_CRC16 = {crc16test.UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC16()};");
            Console.WriteLine($"        public const uint USHORT_CRC16 = {crc16test.UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_USHORT_CRC16 = {crc16test.UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC16()};");
            Console.WriteLine($"        public const uint INT_CRC16 = {crc16test.UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_INT_CRC16 = {crc16test.UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC16()};");
            Console.WriteLine($"        public const uint UINT_CRC16 = {crc16test.UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_UINT_CRC16 = {crc16test.UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC16()};");
            Console.WriteLine($"        public const uint LONG_CRC16 = {crc16test.UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_LONG_CRC16 = {crc16test.UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC16()};");
            Console.WriteLine($"        public const uint ULONG_CRC16 = {crc16test.UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_ULONG_CRC16 = {crc16test.UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC16()};");
            Console.WriteLine($"        public const uint FLOAT_CRC16 = {crc16test.UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_FLOAT_CRC16 = {crc16test.UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC16()};");
            Console.WriteLine($"        public const uint DOUBLE_CRC16 = {crc16test.UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_DOUBLE_CRC16 = {crc16test.UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC16()};");
            Console.WriteLine($"        public const uint DECIMAL_CRC16 = {crc16test.UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_DECIMAL_CRC16 = {crc16test.UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC16()};");
            Console.WriteLine($"        public const uint DATETIME_CRC16 = {crc16test.UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_DATETIME_CRC16 = {crc16test.UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC16()};");
            Console.WriteLine($"        public const uint TIMESPAN_CRC16 = {crc16test.UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_TIMESPAN_CRC16 = {crc16test.UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC16()};");
            Console.WriteLine($"        public const uint CHAR_CRC16 = {crc16test.UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_CHAR_CRC16 = {crc16test.UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_STRING_CRC16 = {crc16test.UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC16()};");
            Console.WriteLine($"        public const uint GUID_CRC16 = {crc16test.UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC16()};");
            Console.WriteLine($"        public const uint NULLABLE_GUID_CRC16 = {crc16test.UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC16()};");


        }
    }
}
