using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class CRC32FluentHashCalculatorTests
    {
        [Fact]
        public uint UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.BoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingBoolArrayPropertyInCalculatorWhenComputeThenReturnBoolArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.BoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableBoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableBoolArrayPropertyInCalculatorWhenComputeThenReturnNullableBoolArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableBoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingBytePropertyInCalculatorWhenComputeThenReturnByteCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.ByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingByteArrayPropertyInCalculatorWhenComputeThenReturnByteArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.ByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableByteArrayPropertyInCalculatorWhenComputeThenReturnNullableByteArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.SbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingSbyteArrayPropertyInCalculatorWhenComputeThenReturnSbyteArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.SbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableSbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableSbyteArrayPropertyInCalculatorWhenComputeThenReturnNullableSbyteArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableSbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingShortPropertyInCalculatorWhenComputeThenReturnShortCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.ShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingShortArrayPropertyInCalculatorWhenComputeThenReturnShortArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.ShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableShortArrayPropertyInCalculatorWhenComputeThenReturnNullableShortArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.UshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, uint>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUshortArrayPropertyInCalculatorWhenComputeThenReturnUshortArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.UshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<uint>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableUshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, uint?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUshortArrayPropertyInCalculatorWhenComputeThenReturnNullableUshortArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableUshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<uint?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingIntPropertyInCalculatorWhenComputeThenReturnIntCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.IntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingIntArrayPropertyInCalculatorWhenComputeThenReturnIntArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.IntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableIntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableIntArrayPropertyInCalculatorWhenComputeThenReturnNullableIntArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableIntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUintPropertyInCalculatorWhenComputeThenReturnUintCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.UintProperty);
            Expression<Func<EntityWithAllSupportedTypes, uint>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUintArrayPropertyInCalculatorWhenComputeThenReturnUintArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.UintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<uint>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableUintProperty);
            Expression<Func<EntityWithAllSupportedTypes, uint?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUintArrayPropertyInCalculatorWhenComputeThenReturnNullableUintArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableUintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<uint?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingLongPropertyInCalculatorWhenComputeThenReturnLongCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.LongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingLongArrayPropertyInCalculatorWhenComputeThenReturnLongArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.LongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableLongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableLongArrayPropertyInCalculatorWhenComputeThenReturnNullableLongArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableLongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.UlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingUlongArrayPropertyInCalculatorWhenComputeThenReturnUlongArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.UlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableUlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableUlongArrayPropertyInCalculatorWhenComputeThenReturnNullableUlongArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableUlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.FloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingFloatArrayPropertyInCalculatorWhenComputeThenReturnFloatArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.FloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableFloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableFloatArrayPropertyInCalculatorWhenComputeThenReturnNullableFloatArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableFloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.DoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDoubleArrayPropertyInCalculatorWhenComputeThenReturnDoubleArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.DoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableDoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDoubleArrayPropertyInCalculatorWhenComputeThenReturnNullableDoubleArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableDoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.DecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDecimalArrayPropertyInCalculatorWhenComputeThenReturnDecimalArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.DecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableDecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDecimalArrayPropertyInCalculatorWhenComputeThenReturnNullableDecimalArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableDecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.DateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingDateTimeArrayPropertyInCalculatorWhenComputeThenReturnDateTimeArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.DateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableDateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableDateTimeArrayPropertyInCalculatorWhenComputeThenReturnNullableDateTimeArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableDateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.TimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnTimeSpanArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.TimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableTimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableTimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingCharPropertyInCalculatorWhenComputeThenReturnCharCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.CharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingCharArrayPropertyInCalculatorWhenComputeThenReturnCharArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.CharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableCharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableCharArrayPropertyInCalculatorWhenComputeThenReturnNullableCharArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableCharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableStringProperty);
            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableStringProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringArrayPropertyInCalculatorWhenComputeThenReturnNullableStringArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringArrayPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringArrayPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.GuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingGuidArrayPropertyInCalculatorWhenComputeThenReturnGuidArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.GuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableGuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableGuidArrayPropertyInCalculatorWhenComputeThenReturnNullableGuidArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableGuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC32, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC32, actual2);


            var calculator2 = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC32, actual3);

            Assert.NotEqual(actual, actual3);
        }
    }
}
