using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class SHA512FluentHashCalculatorTests
    {
        [Fact]
        public byte[] UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.BoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingBoolArrayPropertyInCalculatorWhenComputeThenReturnBoolArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.BoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableBoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBoolArrayPropertyInCalculatorWhenComputeThenReturnNullableBoolArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableBoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingBytePropertyInCalculatorWhenComputeThenReturnByteSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.ByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingByteArrayPropertyInCalculatorWhenComputeThenReturnByteArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.ByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableByteArrayPropertyInCalculatorWhenComputeThenReturnNullableByteArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.SbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingSbyteArrayPropertyInCalculatorWhenComputeThenReturnSbyteArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.SbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableSbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableSbyteArrayPropertyInCalculatorWhenComputeThenReturnNullableSbyteArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableSbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingShortPropertyInCalculatorWhenComputeThenReturnShortSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.ShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingShortArrayPropertyInCalculatorWhenComputeThenReturnShortArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.ShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableShortArrayPropertyInCalculatorWhenComputeThenReturnNullableShortArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.UshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUshortArrayPropertyInCalculatorWhenComputeThenReturnUshortArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.UshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableUshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUshortArrayPropertyInCalculatorWhenComputeThenReturnNullableUshortArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableUshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingIntPropertyInCalculatorWhenComputeThenReturnIntSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.IntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingIntArrayPropertyInCalculatorWhenComputeThenReturnIntArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.IntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableIntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableIntArrayPropertyInCalculatorWhenComputeThenReturnNullableIntArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableIntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUintPropertyInCalculatorWhenComputeThenReturnUintSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.UintProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUintArrayPropertyInCalculatorWhenComputeThenReturnUintArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.UintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableUintProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUintArrayPropertyInCalculatorWhenComputeThenReturnNullableUintArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableUintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingLongPropertyInCalculatorWhenComputeThenReturnLongSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.LongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingLongArrayPropertyInCalculatorWhenComputeThenReturnLongArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.LongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableLongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableLongArrayPropertyInCalculatorWhenComputeThenReturnNullableLongArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableLongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.UlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUlongArrayPropertyInCalculatorWhenComputeThenReturnUlongArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.UlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableUlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUlongArrayPropertyInCalculatorWhenComputeThenReturnNullableUlongArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableUlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.FloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingFloatArrayPropertyInCalculatorWhenComputeThenReturnFloatArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.FloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableFloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableFloatArrayPropertyInCalculatorWhenComputeThenReturnNullableFloatArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableFloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.DoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDoubleArrayPropertyInCalculatorWhenComputeThenReturnDoubleArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.DoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableDoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDoubleArrayPropertyInCalculatorWhenComputeThenReturnNullableDoubleArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableDoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.DecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDecimalArrayPropertyInCalculatorWhenComputeThenReturnDecimalArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.DecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableDecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDecimalArrayPropertyInCalculatorWhenComputeThenReturnNullableDecimalArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableDecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.DateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDateTimeArrayPropertyInCalculatorWhenComputeThenReturnDateTimeArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.DateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableDateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDateTimeArrayPropertyInCalculatorWhenComputeThenReturnNullableDateTimeArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableDateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.TimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnTimeSpanArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.TimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableTimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableTimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingCharPropertyInCalculatorWhenComputeThenReturnCharSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.CharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingCharArrayPropertyInCalculatorWhenComputeThenReturnCharArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.CharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableCharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableCharArrayPropertyInCalculatorWhenComputeThenReturnNullableCharArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableCharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableStringProperty);
            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableStringProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, string?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyInCalculatorWhenComputeThenReturnNullableStringArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.GuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingGuidArrayPropertyInCalculatorWhenComputeThenReturnGuidArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.GuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.Using(e => e.NullableGuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_SHA512, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableGuidArrayPropertyInCalculatorWhenComputeThenReturnNullableGuidArraySHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
            calculator.UsingEach(e => e.NullableGuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_ARRAY_SHA512, actual);
            return actual;
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnSHA512()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_SHA512, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_SHA512, actual2);


            var calculator2 = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA512();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_SHA512, actual3);

            Assert.NotEqual(actual, actual3);
        }
    }
}
