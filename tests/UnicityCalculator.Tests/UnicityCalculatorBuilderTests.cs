using System;
using Xunit;

namespace UnicityCalculator.Tests
{
    public class UnicityCalculatorBuilderTests
    {
        [Fact]
        public void UsingBoolDefaultValueWhenComputeThenReturnBoolCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.BOOL_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.BOOL_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.BOOL_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableBoolDefaultValueWhenComputeThenReturnNullableBoolCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_BOOL_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_BOOL_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_BOOL_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingByteDefaultValueWhenComputeThenReturnByteCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.BYTE_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.BYTE_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.BYTE_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableByteDefaultValueWhenComputeThenReturnNullableByteCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_BYTE_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_BYTE_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_BYTE_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingSbyteDefaultValueWhenComputeThenReturnSbyteCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.SBYTE_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.SBYTE_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.SBYTE_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableSbyteDefaultValueWhenComputeThenReturnNullableSbyteCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_SBYTE_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_SBYTE_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_SBYTE_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingShortDefaultValueWhenComputeThenReturnShortCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.SHORT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.SHORT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.SHORT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableShortDefaultValueWhenComputeThenReturnNullableShortCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_SHORT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_SHORT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_SHORT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingUshortDefaultValueWhenComputeThenReturnUshortCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.USHORT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.USHORT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.USHORT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableUshortDefaultValueWhenComputeThenReturnNullableUshortCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_USHORT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_USHORT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_USHORT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingIntDefaultValueWhenComputeThenReturnIntCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.INT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.INT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.INT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableIntDefaultValueWhenComputeThenReturnNullableIntCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_INT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_INT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_INT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingUintDefaultValueWhenComputeThenReturnUintCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.UINT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.UINT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.UINT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableUintDefaultValueWhenComputeThenReturnNullableUintCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_UINT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_UINT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_UINT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingLongDefaultValueWhenComputeThenReturnLongCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.LONG_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.LONG_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.LONG_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableLongDefaultValueWhenComputeThenReturnNullableLongCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_LONG_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_LONG_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_LONG_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingUlongDefaultValueWhenComputeThenReturnUlongCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.ULONG_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.ULONG_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.ULONG_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableUlongDefaultValueWhenComputeThenReturnNullableUlongCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_ULONG_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_ULONG_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_ULONG_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingFloatDefaultValueWhenComputeThenReturnFloatCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.FLOAT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.FLOAT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.FLOAT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableFloatDefaultValueWhenComputeThenReturnNullableFloatCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_FLOAT_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_FLOAT_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_FLOAT_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingDoubleDefaultValueWhenComputeThenReturnDoubleCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.DOUBLE_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.DOUBLE_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.DOUBLE_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableDoubleDefaultValueWhenComputeThenReturnNullableDoubleCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_DOUBLE_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_DOUBLE_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_DOUBLE_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingDecimalDefaultValueWhenComputeThenReturnDecimalCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.DECIMAL_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.DECIMAL_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.DECIMAL_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableDecimalDefaultValueWhenComputeThenReturnNullableDecimalCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_DECIMAL_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_DECIMAL_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_DECIMAL_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingDateTimeDefaultValueWhenComputeThenReturnDateTimeCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.DATETIME_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.DATETIME_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.DATETIME_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableDateTimeDefaultValueWhenComputeThenReturnNullableDateTimeCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_DATETIME_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_DATETIME_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_DATETIME_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingTimeSpanDefaultValueWhenComputeThenReturnTimeSpanCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.TIMESPAN_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.TIMESPAN_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.TIMESPAN_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableTimeSpanDefaultValueWhenComputeThenReturnNullableTimeSpanCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_TIMESPAN_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_TIMESPAN_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_TIMESPAN_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingCharDefaultValueWhenComputeThenReturnCharCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.CHAR_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.CHAR_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.CHAR_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableCharDefaultValueWhenComputeThenReturnNullableCharCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_CHAR_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_CHAR_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_CHAR_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableStringDefaultValueWhenComputeThenReturnNullableStringCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_STRING_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_STRING_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_STRING_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingGuidDefaultValueWhenComputeThenReturnGuidCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.GUID_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.GUID_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.GUID_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingNullableGuidDefaultValueWhenComputeThenReturnNullableGuidCRC64()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                var actual = calculator
                    .With(Fakes.Consts.NULLABLE_GUID_DEFAULT_VALUE)
                    .Build();

                Assert.Equal(Fakes.Consts.NULLABLE_GUID_CRC64, actual);
            }
            var calc = new UnicityCalculatorBuilder();
            calc.Dispose();
            Assert.Throws<ObjectDisposedException>(() => calc.With(Fakes.Consts.NULLABLE_GUID_DEFAULT_VALUE));
        }

        [Fact]
        public void UsingEntityInstanceWhenComputeThenThrowsTypeNotSupportedException()
        {
            using (var calculator = new UnicityCalculatorBuilder())
            {
                Assert.Throws<TypeNotSupportedException>(() => calculator.With(new Fakes.Entity()));
            }
        }
    }
}
