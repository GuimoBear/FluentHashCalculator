using System;
using System.Linq.Expressions;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class CRC64FluentHashCalculatorTests
    {
        [Fact]
        public void UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();

            calculator.Using(e => e.BoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_CRC64, actual);
        }

        [Fact]
        public void UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableBoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_CRC64, actual);
        }

        [Fact]
        public void UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.ByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_CRC64, actual);
        }

        [Fact]
        public void UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_CRC64, actual);
        }

        [Fact]
        public void UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.SbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_CRC64, actual);
        }

        [Fact]
        public void UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableSbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_CRC64, actual);
        }

        [Fact]
        public void UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.ShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_CRC64, actual);
        }

        [Fact]
        public void UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.UshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableUshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_CRC64, actual);
        }

        [Fact]
        public void UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.IntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableIntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_CRC64, actual);
        }

        [Fact]
        public void UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.UintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableUintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_CRC64, actual);
        }

        [Fact]
        public void UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.LongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_CRC64, actual);
        }

        [Fact]
        public void UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableLongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_CRC64, actual);
        }

        [Fact]
        public void UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.UlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_CRC64, actual);
        }

        [Fact]
        public void UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableUlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_CRC64, actual);
        }

        [Fact]
        public void UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.FloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableFloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_CRC64, actual);
        }

        [Fact]
        public void UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.DoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_CRC64, actual);
        }

        [Fact]
        public void UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableDoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_CRC64, actual);
        }

        [Fact]
        public void UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.DecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_CRC64, actual);
        }

        [Fact]
        public void UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableDecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_CRC64, actual);
        }

        [Fact]
        public void UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.DateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_CRC64, actual);
        }

        [Fact]
        public void UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableDateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_CRC64, actual);
        }

        [Fact]
        public void UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.TimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_CRC64, actual);
        }

        [Fact]
        public void UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableTimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_CRC64, actual);
        }

        [Fact]
        public void UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.CharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_CRC64, actual);
        }

        [Fact]
        public void UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableCharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_CRC64, actual);
        }

        [Fact]
        public void UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableStringProperty);

            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_CRC64, actual);
        }

        [Fact]
        public void UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.GuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_CRC64, actual);
        }

        [Fact]
        public void UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.NullableGuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_CRC64, actual);
        }

        [Fact]
        public void UsingNullEntityWhenComputeThenReturnNullableGuidCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.BoolProperty);

            var actual = calculator.Compute(null);
            Assert.Equal(ulong.MinValue, actual);
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnCRC64()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator.Using(e => e.BoolProperty)
                .UsingEach(e => e.BoolArrayProperty)
                .Using(e => e.NullableBoolProperty)
                .UsingEach(e => e.NullableBoolArrayProperty)
                .Using(e => e.ByteProperty)
                .UsingEach(e => e.ByteArrayProperty)
                .Using(e => e.NullableByteProperty)
                .UsingEach(e => e.NullableByteArrayProperty)
                .Using(e => e.SbyteProperty)
                .UsingEach(e => e.SbyteArrayProperty)
                .Using(e => e.NullableSbyteProperty)
                .UsingEach(e => e.NullableSbyteArrayProperty)
                .Using(e => e.ShortProperty)
                .UsingEach(e => e.ShortArrayProperty)
                .Using(e => e.NullableShortProperty)
                .UsingEach(e => e.NullableShortArrayProperty)
                .Using(e => e.UshortProperty)
                .UsingEach(e => e.UshortArrayProperty)
                .Using(e => e.NullableUshortProperty)
                .UsingEach(e => e.NullableUshortArrayProperty)
                .Using(e => e.IntProperty)
                .UsingEach(e => e.IntArrayProperty)
                .Using(e => e.NullableIntProperty)
                .UsingEach(e => e.NullableIntArrayProperty)
                .Using(e => e.UintProperty)
                .UsingEach(e => e.UintArrayProperty)
                .Using(e => e.NullableUintProperty)
                .UsingEach(e => e.NullableUintArrayProperty)
                .Using(e => e.LongProperty)
                .UsingEach(e => e.LongArrayProperty)
                .Using(e => e.NullableLongProperty)
                .UsingEach(e => e.NullableLongArrayProperty)
                .Using(e => e.UlongProperty)
                .UsingEach(e => e.UlongArrayProperty)
                .Using(e => e.NullableUlongProperty)
                .UsingEach(e => e.NullableUlongArrayProperty)
                .Using(e => e.FloatProperty)
                .UsingEach(e => e.FloatArrayProperty)
                .Using(e => e.NullableFloatProperty)
                .UsingEach(e => e.NullableFloatArrayProperty)
                .Using(e => e.DoubleProperty)
                .UsingEach(e => e.DoubleArrayProperty)
                .Using(e => e.NullableDoubleProperty)
                .UsingEach(e => e.NullableDoubleArrayProperty)
                .Using(e => e.DecimalProperty)
                .UsingEach(e => e.DecimalArrayProperty)
                .Using(e => e.NullableDecimalProperty)
                .UsingEach(e => e.NullableDecimalArrayProperty)
                .Using(e => e.DateTimeProperty)
                .UsingEach(e => e.DateTimeArrayProperty)
                .Using(e => e.NullableDateTimeProperty)
                .UsingEach(e => e.NullableDateTimeArrayProperty)
                .Using(e => e.TimeSpanProperty)
                .UsingEach(e => e.TimeSpanArrayProperty)
                .Using(e => e.NullableTimeSpanProperty)
                .UsingEach(e => e.NullableTimeSpanArrayProperty)
                .Using(e => e.CharProperty)
                .UsingEach(e => e.CharArrayProperty)
                .Using(e => e.NullableCharProperty)
                .UsingEach(e => e.NullableCharArrayProperty)
                .Using(e => e.NullableStringProperty)
                .UsingEach(e => e.NullableStringArrayProperty)
                .Using(e => e.GuidProperty)
                .UsingEach(e => e.GuidArrayProperty)
                .Using(e => e.NullableGuidProperty)
                .UsingEach(e => e.NullableGuidArrayProperty);

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC64, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC64, actual2);


            var calculator2 = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC64();
            calculator2.Using(e => e.BoolProperty)
                .UsingEach(e => e.BoolArrayProperty)
                .Using(e => e.NullableBoolProperty)
                .UsingEach(e => e.NullableBoolArrayProperty)
                .Using(e => e.ByteProperty)
                .UsingEach(e => e.ByteArrayProperty)
                .Using(e => e.NullableByteProperty)
                .UsingEach(e => e.NullableByteArrayProperty)
                .Using(e => e.SbyteProperty)
                .UsingEach(e => e.SbyteArrayProperty)
                .Using(e => e.NullableSbyteProperty)
                .UsingEach(e => e.NullableSbyteArrayProperty)
                .Using(e => e.ShortProperty)
                .UsingEach(e => e.ShortArrayProperty)
                .Using(e => e.NullableShortProperty)
                .UsingEach(e => e.NullableShortArrayProperty)
                .Using(e => e.UshortProperty)
                .UsingEach(e => e.UshortArrayProperty)
                .Using(e => e.NullableUshortProperty)
                .UsingEach(e => e.NullableUshortArrayProperty)
                .Using(e => e.IntProperty)
                .UsingEach(e => e.IntArrayProperty)
                .Using(e => e.NullableIntProperty)
                .UsingEach(e => e.NullableIntArrayProperty)
                .UsingEach(e => e.UintArrayProperty)
                .Using(e => e.NullableUintProperty)
                .UsingEach(e => e.NullableUintArrayProperty)
                .Using(e => e.LongProperty)
                .UsingEach(e => e.LongArrayProperty)
                .Using(e => e.NullableLongProperty)
                .UsingEach(e => e.NullableLongArrayProperty)
                .Using(e => e.UlongProperty)
                .UsingEach(e => e.UlongArrayProperty)
                .Using(e => e.NullableUlongProperty)
                .UsingEach(e => e.NullableUlongArrayProperty)
                .Using(e => e.FloatProperty)
                .UsingEach(e => e.FloatArrayProperty)
                .Using(e => e.NullableFloatProperty)
                .UsingEach(e => e.NullableFloatArrayProperty)
                .Using(e => e.DoubleProperty)
                .UsingEach(e => e.DoubleArrayProperty)
                .Using(e => e.NullableDoubleProperty)
                .UsingEach(e => e.NullableDoubleArrayProperty)
                .Using(e => e.DecimalProperty)
                .UsingEach(e => e.DecimalArrayProperty)
                .Using(e => e.NullableDecimalProperty)
                .UsingEach(e => e.NullableDecimalArrayProperty)
                .Using(e => e.DateTimeProperty)
                .UsingEach(e => e.DateTimeArrayProperty)
                .Using(e => e.NullableDateTimeProperty)
                .UsingEach(e => e.NullableDateTimeArrayProperty)
                .Using(e => e.TimeSpanProperty)
                .UsingEach(e => e.TimeSpanArrayProperty)
                .Using(e => e.NullableTimeSpanProperty)
                .UsingEach(e => e.NullableTimeSpanArrayProperty)
                .Using(e => e.CharProperty)
                .UsingEach(e => e.CharArrayProperty)
                .Using(e => e.NullableCharProperty)
                .UsingEach(e => e.NullableCharArrayProperty)
                .Using(e => e.NullableStringProperty)
                .UsingEach(e => e.NullableStringArrayProperty)
                .Using(e => e.GuidProperty)
                .UsingEach(e => e.GuidArrayProperty)
                .Using(e => e.NullableGuidProperty)
                .UsingEach(e => e.NullableGuidArrayProperty);

            var actual3 = calculator2.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC64, actual3);
        }
    }
}
