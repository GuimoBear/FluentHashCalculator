using System;
using System.Linq.Expressions;
using UnicityCalculator.Tests.Fakes;
using Xunit;

namespace UnicityCalculator.Tests
{
    public class UnicityCalculatorTests
    {
        [Fact]
        public void UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.BoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_CRC64, actual);
        }

        [Fact]
        public void UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableBoolProperty);

            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_CRC64, actual);
        }

        [Fact]
        public void UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.ByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_CRC64, actual);
        }

        [Fact]
        public void UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableByteProperty);

            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_CRC64, actual);
        }

        [Fact]
        public void UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.SbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_CRC64, actual);
        }

        [Fact]
        public void UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableSbyteProperty);

            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_CRC64, actual);
        }

        [Fact]
        public void UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.ShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableShortProperty);

            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_CRC64, actual);
        }

        [Fact]
        public void UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.UshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableUshortProperty);

            Expression<Func<EntityWithAllSupportedTypes, ushort?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_CRC64, actual);
        }

        [Fact]
        public void UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.IntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableIntProperty);

            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_CRC64, actual);
        }

        [Fact]
        public void UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.UintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableUintProperty);

            Expression<Func<EntityWithAllSupportedTypes, uint?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_CRC64, actual);
        }

        [Fact]
        public void UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.LongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_CRC64, actual);
        }

        [Fact]
        public void UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableLongProperty);

            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_CRC64, actual);
        }

        [Fact]
        public void UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.UlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_CRC64, actual);
        }

        [Fact]
        public void UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableUlongProperty);

            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_CRC64, actual);
        }

        [Fact]
        public void UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.FloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_CRC64, actual);
        }

        [Fact]
        public void UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableFloatProperty);

            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_CRC64, actual);
        }

        [Fact]
        public void UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.DoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_CRC64, actual);
        }

        [Fact]
        public void UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableDoubleProperty);

            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_CRC64, actual);
        }

        [Fact]
        public void UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.DecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_CRC64, actual);
        }

        [Fact]
        public void UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableDecimalProperty);

            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_CRC64, actual);
        }

        [Fact]
        public void UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.DateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_CRC64, actual);
        }

        [Fact]
        public void UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableDateTimeProperty);

            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_CRC64, actual);
        }

        [Fact]
        public void UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.TimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_CRC64, actual);
        }

        [Fact]
        public void UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableTimeSpanProperty);

            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_CRC64, actual);
        }

        [Fact]
        public void UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.CharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_CRC64, actual);
        }

        [Fact]
        public void UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableCharProperty);

            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_CRC64, actual);
        }

        [Fact]
        public void UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableStringProperty);

            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_CRC64, actual);
        }

        [Fact]
        public void UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.GuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_CRC64, actual);
        }

        [Fact]
        public void UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.NullableGuidProperty);

            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_CRC64, actual);
        }

        [Fact]
        public void UsingNullEntityWhenComputeThenReturnNullableGuidCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.BoolProperty);

            var actual = calculator.Compute(null);
            Assert.Equal(ulong.MinValue, actual);
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnCRC64()
        {
            var calculator = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.BoolProperty)
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC64, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC64, actual2);


            var calculator2 = new UnicityCalculator<EntityWithAllSupportedTypes>()
                .Using(e => e.BoolProperty)
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC64, actual3);
        }
    }
}
