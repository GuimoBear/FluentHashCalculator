using System;
using System.Linq.Expressions;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class CRC16FluentHashCalculatorTests
    {
        [Fact]
        public ushort UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();

            calculator.Using(e => e.BoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableBoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.ByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.SbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableSbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.ShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.UshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableUshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.IntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableIntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.UintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableUintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.LongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableLongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.UlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableUlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.FloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableFloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.DoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableDoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.DecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableDecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.DateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableDateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.TimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableTimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.CharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableCharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableStringProperty);

            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.GuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableGuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullEntityWhenComputeThenReturnNullableGuidCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.BoolProperty);

            var actual = calculator.Compute(null);
            Assert.Equal(ulong.MinValue, actual);
            return actual;
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnCRC16()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.BoolProperty)
                .Using(e => e.NullableBoolProperty)
                .Using(e => e.ByteProperty)
                .Using(e => e.NullableByteProperty)
                .Using(e => e.SbyteProperty)
                .Using(e => e.NullableSbyteProperty)
                .Using(e => e.ShortProperty)
                .Using(e => e.NullableShortProperty)
                .Using(e => e.UshortProperty)
                .Using(e => e.NullableUshortProperty)
                .Using(e => e.IntProperty)
                .Using(e => e.NullableIntProperty)
                .Using(e => e.UintProperty)
                .Using(e => e.NullableUintProperty)
                .Using(e => e.LongProperty)
                .Using(e => e.NullableLongProperty)
                .Using(e => e.UlongProperty)
                .Using(e => e.NullableUlongProperty)
                .Using(e => e.FloatProperty)
                .Using(e => e.NullableFloatProperty)
                .Using(e => e.DoubleProperty)
                .Using(e => e.NullableDoubleProperty)
                .Using(e => e.DecimalProperty)
                .Using(e => e.NullableDecimalProperty)
                .Using(e => e.DateTimeProperty)
                .Using(e => e.NullableDateTimeProperty)
                .Using(e => e.TimeSpanProperty)
                .Using(e => e.NullableTimeSpanProperty)
                .Using(e => e.CharProperty)
                .Using(e => e.NullableCharProperty)
                .Using(e => e.NullableStringProperty)
                .Using(e => e.GuidProperty)
                .Using(e => e.NullableGuidProperty);

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC16, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC16, actual2);


            var calculator2 = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator2.Using(e => e.BoolProperty)
                .Using(e => e.NullableBoolProperty)
                .Using(e => e.ByteProperty)
                .Using(e => e.NullableByteProperty)
                .Using(e => e.SbyteProperty)
                .Using(e => e.NullableSbyteProperty)
                .Using(e => e.ShortProperty)
                .Using(e => e.NullableShortProperty)
                .Using(e => e.UshortProperty)
                .Using(e => e.NullableUshortProperty)
                .Using(e => e.IntProperty)
                .Using(e => e.NullableIntProperty)
                .Using(e => e.NullableUintProperty)
                .Using(e => e.LongProperty)
                .Using(e => e.NullableLongProperty)
                .Using(e => e.UlongProperty)
                .Using(e => e.NullableUlongProperty)
                .Using(e => e.FloatProperty)
                .Using(e => e.NullableFloatProperty)
                .Using(e => e.DoubleProperty)
                .Using(e => e.NullableDoubleProperty)
                .Using(e => e.DecimalProperty)
                .Using(e => e.NullableDecimalProperty)
                .Using(e => e.DateTimeProperty)
                .Using(e => e.NullableDateTimeProperty)
                .Using(e => e.TimeSpanProperty)
                .Using(e => e.NullableTimeSpanProperty)
                .Using(e => e.CharProperty)
                .Using(e => e.NullableCharProperty)
                .Using(e => e.NullableStringProperty)
                .Using(e => e.GuidProperty)
                .Using(e => e.NullableGuidProperty);

            var actual3 = calculator2.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC16, actual3);
        }
    }
}
