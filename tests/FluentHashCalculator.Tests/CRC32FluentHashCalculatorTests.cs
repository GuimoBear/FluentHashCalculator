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
            calculator.Using(e => e.BoolProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.BoolArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableBoolProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableBoolArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.ByteProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.ByteArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableByteProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableByteArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.SbyteProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.SbyteArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableSbyteProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableSbyteArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.ShortProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.ShortArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableShortProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableShortArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.UshortProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.UshortArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableUshortProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableUshortArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.IntProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.IntArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableIntProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableIntArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.UintProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.UintArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableUintProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableUintArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.LongProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.LongArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableLongProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableLongArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.UlongProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.UlongArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableUlongProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableUlongArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.FloatProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.FloatArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableFloatProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableFloatArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.DoubleProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.DoubleArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableDoubleProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableDoubleArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.DecimalProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.DecimalArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableDecimalProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableDecimalArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.DateTimeProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.DateTimeArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableDateTimeProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableDateTimeArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.TimeSpanProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.TimeSpanArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableTimeSpanProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableTimeSpanArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.CharProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.CharArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableCharProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableCharArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableStringProperty, ignoreError: true);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableStringProperty, Encoding.Unicode, ignoreError: true);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_CRC32, actual);

            return actual;
        }

        [Fact]
        public uint UsingNullableStringPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF32, ignoreError: true);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_CRC32, actual);

            return actual;
        }

        [Fact]
        public uint UsingNullableStringArrayPropertyInCalculatorWhenComputeThenReturnNullableStringArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableStringArrayProperty, ignoreError: true);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingNullableStringArrayPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.Unicode, ignoreError: true);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_CRC32, actual);

            return actual;
        }

        [Fact]
        public uint UsingNullableStringArrayPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringArrayCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF32, ignoreError: true);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_CRC32, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty, ignoreError: true);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_CRC32, actual);

            return actual;
        }

        [Fact]
        public uint UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.GuidProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.GuidArrayProperty, ignoreError: true);
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
            calculator.Using(e => e.NullableGuidProperty, ignoreError: true);
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
            calculator.UsingEach(e => e.NullableGuidArrayProperty, ignoreError: true);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_ARRAY_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingComplexPropertyInCalculatorWhenComputeThenReturnEntityIdCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.Child);
            Expression<Func<EntityWithAllSupportedTypes, Entity>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(uint.MinValue, actual);
            calculator.Using(e => e.Child).WithCRC32(calc => calc.Using(e => e.Id));
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHILD_ENTITY_ID_CRC32, actual);
            return actual;
        }

        [Fact]
        public uint UsingComplexListPropertyInCalculatorWhenComputeThenReturnEntityIdCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.UsingEach(e => e.ChildList);
            Expression<Func<EntityWithAllSupportedTypes, Entity>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(uint.MinValue, actual);
            calculator.UsingEach(e => e.ChildList).WithCRC32(calc => calc.Using(e => e.Id));
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHILD_ENTITY_ID_CRC32, actual);
            return actual;
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnCRC32()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator.Using(e => e.BoolProperty, ignoreError: true)
                .UsingEach(e => e.BoolArrayProperty, ignoreError: true)
                .Using(e => e.NullableBoolProperty, ignoreError: true)
                .UsingEach(e => e.NullableBoolArrayProperty, ignoreError: true)
                .Using(e => e.ByteProperty, ignoreError: true)
                .UsingEach(e => e.ByteArrayProperty, ignoreError: true)
                .Using(e => e.NullableByteProperty, ignoreError: true)
                .UsingEach(e => e.NullableByteArrayProperty, ignoreError: true)
                .Using(e => e.SbyteProperty, ignoreError: true)
                .UsingEach(e => e.SbyteArrayProperty, ignoreError: true)
                .Using(e => e.NullableSbyteProperty, ignoreError: true)
                .UsingEach(e => e.NullableSbyteArrayProperty, ignoreError: true)
                .Using(e => e.ShortProperty, ignoreError: true)
                .UsingEach(e => e.ShortArrayProperty, ignoreError: true)
                .Using(e => e.NullableShortProperty, ignoreError: true)
                .UsingEach(e => e.NullableShortArrayProperty, ignoreError: true)
                .Using(e => e.UshortProperty, ignoreError: true)
                .UsingEach(e => e.UshortArrayProperty, ignoreError: true)
                .Using(e => e.NullableUshortProperty, ignoreError: true)
                .UsingEach(e => e.NullableUshortArrayProperty, ignoreError: true)
                .Using(e => e.IntProperty, ignoreError: true)
                .UsingEach(e => e.IntArrayProperty, ignoreError: true)
                .Using(e => e.NullableIntProperty, ignoreError: true)
                .UsingEach(e => e.NullableIntArrayProperty, ignoreError: true)
                .Using(e => e.UintProperty, ignoreError: true)
                .UsingEach(e => e.UintArrayProperty, ignoreError: true)
                .Using(e => e.NullableUintProperty, ignoreError: true)
                .UsingEach(e => e.NullableUintArrayProperty, ignoreError: true)
                .Using(e => e.LongProperty, ignoreError: true)
                .UsingEach(e => e.LongArrayProperty, ignoreError: true)
                .Using(e => e.NullableLongProperty, ignoreError: true)
                .UsingEach(e => e.NullableLongArrayProperty, ignoreError: true)
                .Using(e => e.UlongProperty, ignoreError: true)
                .UsingEach(e => e.UlongArrayProperty, ignoreError: true)
                .Using(e => e.NullableUlongProperty, ignoreError: true)
                .UsingEach(e => e.NullableUlongArrayProperty, ignoreError: true)
                .Using(e => e.FloatProperty, ignoreError: true)
                .UsingEach(e => e.FloatArrayProperty, ignoreError: true)
                .Using(e => e.NullableFloatProperty, ignoreError: true)
                .UsingEach(e => e.NullableFloatArrayProperty, ignoreError: true)
                .Using(e => e.DoubleProperty, ignoreError: true)
                .UsingEach(e => e.DoubleArrayProperty, ignoreError: true)
                .Using(e => e.NullableDoubleProperty, ignoreError: true)
                .UsingEach(e => e.NullableDoubleArrayProperty, ignoreError: true)
                .Using(e => e.DecimalProperty, ignoreError: true)
                .UsingEach(e => e.DecimalArrayProperty, ignoreError: true)
                .Using(e => e.NullableDecimalProperty, ignoreError: true)
                .UsingEach(e => e.NullableDecimalArrayProperty, ignoreError: true)
                .Using(e => e.DateTimeProperty, ignoreError: true)
                .UsingEach(e => e.DateTimeArrayProperty, ignoreError: true)
                .Using(e => e.NullableDateTimeProperty, ignoreError: true)
                .UsingEach(e => e.NullableDateTimeArrayProperty, ignoreError: true)
                .Using(e => e.TimeSpanProperty, ignoreError: true)
                .UsingEach(e => e.TimeSpanArrayProperty, ignoreError: true)
                .Using(e => e.NullableTimeSpanProperty, ignoreError: true)
                .UsingEach(e => e.NullableTimeSpanArrayProperty, ignoreError: true)
                .Using(e => e.CharProperty, ignoreError: true)
                .UsingEach(e => e.CharArrayProperty, ignoreError: true)
                .Using(e => e.NullableCharProperty, ignoreError: true)
                .UsingEach(e => e.NullableCharArrayProperty, ignoreError: true)
                .Using(e => e.NullableStringProperty, ignoreError: true)
                .UsingEach(e => e.NullableStringArrayProperty, ignoreError: true)
                .Using(e => e.GuidProperty, ignoreError: true)
                .UsingEach(e => e.GuidArrayProperty, ignoreError: true)
                .Using(e => e.NullableGuidProperty, ignoreError: true)
                .UsingEach(e => e.NullableGuidArrayProperty, ignoreError: true);

            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC32, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC32, actual2);


            var calculator2 = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.CRC32();
            calculator2.Using(e => e.BoolProperty, ignoreError: true)
                .UsingEach(e => e.BoolArrayProperty, ignoreError: true)
                .Using(e => e.NullableBoolProperty, ignoreError: true)
                .UsingEach(e => e.NullableBoolArrayProperty, ignoreError: true)
                .Using(e => e.ByteProperty, ignoreError: true)
                .UsingEach(e => e.ByteArrayProperty, ignoreError: true)
                .Using(e => e.NullableByteProperty, ignoreError: true)
                .UsingEach(e => e.NullableByteArrayProperty, ignoreError: true)
                .Using(e => e.SbyteProperty, ignoreError: true)
                .UsingEach(e => e.SbyteArrayProperty, ignoreError: true)
                .Using(e => e.NullableSbyteProperty, ignoreError: true)
                .UsingEach(e => e.NullableSbyteArrayProperty, ignoreError: true)
                .Using(e => e.ShortProperty, ignoreError: true)
                .UsingEach(e => e.ShortArrayProperty, ignoreError: true)
                .Using(e => e.NullableShortProperty, ignoreError: true)
                .UsingEach(e => e.NullableShortArrayProperty, ignoreError: true)
                .Using(e => e.UshortProperty, ignoreError: true)
                .UsingEach(e => e.UshortArrayProperty, ignoreError: true)
                .Using(e => e.NullableUshortProperty, ignoreError: true)
                .UsingEach(e => e.NullableUshortArrayProperty, ignoreError: true)
                .Using(e => e.IntProperty, ignoreError: true)
                .UsingEach(e => e.IntArrayProperty, ignoreError: true)
                .Using(e => e.NullableIntProperty, ignoreError: true)
                .UsingEach(e => e.NullableIntArrayProperty, ignoreError: true)
                .UsingEach(e => e.UintArrayProperty, ignoreError: true)
                .Using(e => e.NullableUintProperty, ignoreError: true)
                .UsingEach(e => e.NullableUintArrayProperty, ignoreError: true)
                .Using(e => e.LongProperty, ignoreError: true)
                .UsingEach(e => e.LongArrayProperty, ignoreError: true)
                .Using(e => e.NullableLongProperty, ignoreError: true)
                .UsingEach(e => e.NullableLongArrayProperty, ignoreError: true)
                .Using(e => e.UlongProperty, ignoreError: true)
                .UsingEach(e => e.UlongArrayProperty, ignoreError: true)
                .Using(e => e.NullableUlongProperty, ignoreError: true)
                .UsingEach(e => e.NullableUlongArrayProperty, ignoreError: true)
                .Using(e => e.FloatProperty, ignoreError: true)
                .UsingEach(e => e.FloatArrayProperty, ignoreError: true)
                .Using(e => e.NullableFloatProperty, ignoreError: true)
                .UsingEach(e => e.NullableFloatArrayProperty, ignoreError: true)
                .Using(e => e.DoubleProperty, ignoreError: true)
                .UsingEach(e => e.DoubleArrayProperty, ignoreError: true)
                .Using(e => e.NullableDoubleProperty, ignoreError: true)
                .UsingEach(e => e.NullableDoubleArrayProperty, ignoreError: true)
                .Using(e => e.DecimalProperty, ignoreError: true)
                .UsingEach(e => e.DecimalArrayProperty, ignoreError: true)
                .Using(e => e.NullableDecimalProperty, ignoreError: true)
                .UsingEach(e => e.NullableDecimalArrayProperty, ignoreError: true)
                .Using(e => e.DateTimeProperty, ignoreError: true)
                .UsingEach(e => e.DateTimeArrayProperty, ignoreError: true)
                .Using(e => e.NullableDateTimeProperty, ignoreError: true)
                .UsingEach(e => e.NullableDateTimeArrayProperty, ignoreError: true)
                .Using(e => e.TimeSpanProperty, ignoreError: true)
                .UsingEach(e => e.TimeSpanArrayProperty, ignoreError: true)
                .Using(e => e.NullableTimeSpanProperty, ignoreError: true)
                .UsingEach(e => e.NullableTimeSpanArrayProperty, ignoreError: true)
                .Using(e => e.CharProperty, ignoreError: true)
                .UsingEach(e => e.CharArrayProperty, ignoreError: true)
                .Using(e => e.NullableCharProperty, ignoreError: true)
                .UsingEach(e => e.NullableCharArrayProperty, ignoreError: true)
                .Using(e => e.NullableStringProperty, ignoreError: true)
                .UsingEach(e => e.NullableStringArrayProperty, ignoreError: true)
                .Using(e => e.GuidProperty, ignoreError: true)
                .UsingEach(e => e.GuidArrayProperty, ignoreError: true)
                .Using(e => e.NullableGuidProperty, ignoreError: true)
                .UsingEach(e => e.NullableGuidArrayProperty, ignoreError: true);

            var actual3 = calculator2.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC32, actual3);

            Assert.NotEqual(actual, actual3);
        }
    }
}
