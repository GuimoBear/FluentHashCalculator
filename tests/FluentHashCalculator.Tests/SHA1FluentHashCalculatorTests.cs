using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class SHA1FluentHashCalculatorTests
    {
        [Fact]
        public byte[] UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.BoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingBoolArrayPropertyInCalculatorWhenComputeThenReturnBoolArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.BoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableBoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBoolArrayPropertyInCalculatorWhenComputeThenReturnNullableBoolArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableBoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingBytePropertyInCalculatorWhenComputeThenReturnByteSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.ByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingByteArrayPropertyInCalculatorWhenComputeThenReturnByteArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.ByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableByteArrayPropertyInCalculatorWhenComputeThenReturnNullableByteArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.SbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingSbyteArrayPropertyInCalculatorWhenComputeThenReturnSbyteArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.SbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableSbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableSbyteArrayPropertyInCalculatorWhenComputeThenReturnNullableSbyteArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableSbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingShortPropertyInCalculatorWhenComputeThenReturnShortSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.ShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingShortArrayPropertyInCalculatorWhenComputeThenReturnShortArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.ShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableShortArrayPropertyInCalculatorWhenComputeThenReturnNullableShortArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.UshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUshortArrayPropertyInCalculatorWhenComputeThenReturnUshortArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.UshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableUshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUshortArrayPropertyInCalculatorWhenComputeThenReturnNullableUshortArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableUshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingIntPropertyInCalculatorWhenComputeThenReturnIntSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.IntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingIntArrayPropertyInCalculatorWhenComputeThenReturnIntArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.IntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableIntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableIntArrayPropertyInCalculatorWhenComputeThenReturnNullableIntArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableIntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUintPropertyInCalculatorWhenComputeThenReturnUintSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.UintProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUintArrayPropertyInCalculatorWhenComputeThenReturnUintArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.UintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableUintProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUintArrayPropertyInCalculatorWhenComputeThenReturnNullableUintArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableUintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingLongPropertyInCalculatorWhenComputeThenReturnLongSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.LongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingLongArrayPropertyInCalculatorWhenComputeThenReturnLongArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.LongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableLongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableLongArrayPropertyInCalculatorWhenComputeThenReturnNullableLongArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableLongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.UlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUlongArrayPropertyInCalculatorWhenComputeThenReturnUlongArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.UlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableUlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUlongArrayPropertyInCalculatorWhenComputeThenReturnNullableUlongArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableUlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.FloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingFloatArrayPropertyInCalculatorWhenComputeThenReturnFloatArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.FloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableFloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableFloatArrayPropertyInCalculatorWhenComputeThenReturnNullableFloatArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableFloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.DoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDoubleArrayPropertyInCalculatorWhenComputeThenReturnDoubleArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.DoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableDoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDoubleArrayPropertyInCalculatorWhenComputeThenReturnNullableDoubleArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableDoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.DecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDecimalArrayPropertyInCalculatorWhenComputeThenReturnDecimalArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.DecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableDecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDecimalArrayPropertyInCalculatorWhenComputeThenReturnNullableDecimalArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableDecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.DateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDateTimeArrayPropertyInCalculatorWhenComputeThenReturnDateTimeArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.DateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableDateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDateTimeArrayPropertyInCalculatorWhenComputeThenReturnNullableDateTimeArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableDateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.TimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnTimeSpanArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.TimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableTimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableTimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingCharPropertyInCalculatorWhenComputeThenReturnCharSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.CharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingCharArrayPropertyInCalculatorWhenComputeThenReturnCharArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.CharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableCharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableCharArrayPropertyInCalculatorWhenComputeThenReturnNullableCharArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableCharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableStringProperty);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableStringProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_SHA1, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_SHA1, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyInCalculatorWhenComputeThenReturnNullableStringArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_SHA1, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_SHA1, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_SHA1, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.GuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingGuidArrayPropertyInCalculatorWhenComputeThenReturnGuidArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.GuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.Using(e => e.NullableGuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_SHA1, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableGuidArrayPropertyInCalculatorWhenComputeThenReturnNullableGuidArraySHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
            calculator.UsingEach(e => e.NullableGuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_ARRAY_SHA1, actual);
            return actual;
        }

        [Fact]
        public void UsingAllPropertiesInCalculatorWhenComputeThenReturnSHA1()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_SHA1, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_SHA1, actual2);


            var calculator2 = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.SHA1();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_SHA1, actual3);

            Assert.NotEqual(actual, actual3);
        }
    }
}
