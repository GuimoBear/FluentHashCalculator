using System;
using System.Linq.Expressions;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class CRC32FluentHashCalculatorTests
    {
        [Fact]
        public uint UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();

            calculator.Using(e => e.BoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableBoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.ByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.SbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableSbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.ShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.UshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableUshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.IntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableIntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.UintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableUintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.LongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableLongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.UlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableUlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.FloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableFloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.DoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableDoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.DecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableDecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.DateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableDateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.TimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableTimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.CharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableCharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableStringProperty);

            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.GuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableGuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullEntityWhenComputeThenReturnNullableGuidCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.BoolProperty);

            var actual = calculator.Compute(null);
            Assert.Equal(ulong.MinValue, actual);
            return actual;
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnCRC32()
        {
            var calculator = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC32, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC32, actual2);


            var calculator2 = new AbstractCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC32, actual3);
        }
    }
}
