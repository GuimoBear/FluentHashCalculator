using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class CRC16FluentHashCalculatorTests
    {
        [Fact]
        public ushort UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.BoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingBoolArrayPropertyInCalculatorWhenComputeThenReturnBoolArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.BoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableBoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableBoolArrayPropertyInCalculatorWhenComputeThenReturnNullableBoolArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableBoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.ByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingByteArrayPropertyInCalculatorWhenComputeThenReturnByteArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.ByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableByteArrayPropertyInCalculatorWhenComputeThenReturnNullableByteArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.SbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingSbyteArrayPropertyInCalculatorWhenComputeThenReturnSbyteArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.SbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableSbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableSbyteArrayPropertyInCalculatorWhenComputeThenReturnNullableSbyteArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableSbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.ShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingShortArrayPropertyInCalculatorWhenComputeThenReturnShortArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.ShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableShortArrayPropertyInCalculatorWhenComputeThenReturnNullableShortArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.UshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ushort>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUshortArrayPropertyInCalculatorWhenComputeThenReturnUshortArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.UshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ushort>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableUshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ushort?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUshortArrayPropertyInCalculatorWhenComputeThenReturnNullableUshortArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableUshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ushort?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.IntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingIntArrayPropertyInCalculatorWhenComputeThenReturnIntArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.IntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableIntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableIntArrayPropertyInCalculatorWhenComputeThenReturnNullableIntArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableIntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.UintProperty);
            Expression<Func<EntityWithAllSupportedTypes, uint>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUintArrayPropertyInCalculatorWhenComputeThenReturnUintArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.UintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<uint>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableUintProperty);
            Expression<Func<EntityWithAllSupportedTypes, uint?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUintArrayPropertyInCalculatorWhenComputeThenReturnNullableUintArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableUintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<uint?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.LongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingLongArrayPropertyInCalculatorWhenComputeThenReturnLongArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.LongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableLongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableLongArrayPropertyInCalculatorWhenComputeThenReturnNullableLongArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableLongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.UlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingUlongArrayPropertyInCalculatorWhenComputeThenReturnUlongArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.UlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableUlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableUlongArrayPropertyInCalculatorWhenComputeThenReturnNullableUlongArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableUlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.FloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingFloatArrayPropertyInCalculatorWhenComputeThenReturnFloatArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.FloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableFloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableFloatArrayPropertyInCalculatorWhenComputeThenReturnNullableFloatArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableFloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.DoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDoubleArrayPropertyInCalculatorWhenComputeThenReturnDoubleArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.DoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableDoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDoubleArrayPropertyInCalculatorWhenComputeThenReturnNullableDoubleArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableDoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.DecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDecimalArrayPropertyInCalculatorWhenComputeThenReturnDecimalArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.DecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableDecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDecimalArrayPropertyInCalculatorWhenComputeThenReturnNullableDecimalArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableDecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.DateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingDateTimeArrayPropertyInCalculatorWhenComputeThenReturnDateTimeArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.DateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableDateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableDateTimeArrayPropertyInCalculatorWhenComputeThenReturnNullableDateTimeArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableDateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.TimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnTimeSpanArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.TimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableTimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableTimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.CharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingCharArrayPropertyInCalculatorWhenComputeThenReturnCharArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.CharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableCharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableCharArrayPropertyInCalculatorWhenComputeThenReturnNullableCharArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableCharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableStringProperty);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableStringPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableStringProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_CRC16, actual);

            return actual;
        }

        [Fact]
        public ushort UsingNullableStringPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_CRC16, actual);

            return actual;
        }

        [Fact]
        public ushort UsingNullableStringArrayPropertyInCalculatorWhenComputeThenReturnNullableStringArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableStringArrayPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_CRC16, actual);

            return actual;
        }

        [Fact]
        public ushort UsingNullableStringArrayPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_CRC16, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_CRC16, actual);

            return actual;
        }

        [Fact]
        public ushort UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.GuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingGuidArrayPropertyInCalculatorWhenComputeThenReturnGuidArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.GuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.NullableGuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullableGuidArrayPropertyInCalculatorWhenComputeThenReturnNullableGuidArrayCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.NullableGuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_ARRAY_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingNullEntityWhenComputeThenReturnNullableGuidCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.BoolProperty);

            var actual = calculator.Compute(null);
            Assert.Equal(ulong.MinValue, actual);
            return actual;
        }

        [Fact]
        public ushort UsingComplexPropertyInCalculatorWhenComputeThenReturnEntityIdCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.Using(e => e.Child);
            Expression<Func<EntityWithAllSupportedTypes, Entity>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(0, actual);
            calculator.Using(e => e.Child).WithCRC16(calc => calc.Using(e => e.Id));
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            //Assert.Equal(Consts.CHILD_ENTITY_ID_CRC16, actual);
            return actual;
        }

        [Fact]
        public ushort UsingComplexListPropertyInCalculatorWhenComputeThenReturnEntityIdCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
            calculator.UsingEach(e => e.ChildList);
            Expression<Func<EntityWithAllSupportedTypes, Entity>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(0, actual);
            calculator.UsingEach(e => e.ChildList).WithCRC16(calc => calc.Using(e => e.Id));
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            //Assert.Equal(Consts.CHILD_ENTITY_ID_CRC16, actual);
            return actual;
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnCRC16()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC16, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC16, actual2);


            var calculator2 = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC16();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC16, actual3);

            Assert.NotEqual(actual, actual3);
        }
    }
}
