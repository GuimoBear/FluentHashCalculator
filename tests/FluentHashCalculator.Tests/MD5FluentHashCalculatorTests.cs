using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class MD5FluentHashCalculatorTests
    {
        [Fact]
        public byte[] UsingBoolPropertyInCalculatorWhenComputeThenReturnBoolMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.BoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingBoolArrayPropertyInCalculatorWhenComputeThenReturnBoolArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.BoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BOOL_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBoolPropertyInCalculatorWhenComputeThenReturnNullableBoolMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableBoolProperty);
            Expression<Func<EntityWithAllSupportedTypes, bool?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBoolArrayPropertyInCalculatorWhenComputeThenReturnNullableBoolArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableBoolArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<bool?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BOOL_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingBytePropertyInCalculatorWhenComputeThenReturnByteMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.ByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingByteArrayPropertyInCalculatorWhenComputeThenReturnByteArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.ByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.BYTE_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableBytePropertyInCalculatorWhenComputeThenReturnNullableByteMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableByteProperty);
            Expression<Func<EntityWithAllSupportedTypes, byte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableByteArrayPropertyInCalculatorWhenComputeThenReturnNullableByteArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableByteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<byte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_BYTE_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingSbytePropertyInCalculatorWhenComputeThenReturnSbyteMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.SbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingSbyteArrayPropertyInCalculatorWhenComputeThenReturnSbyteArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.SbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SBYTE_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableSbytePropertyInCalculatorWhenComputeThenReturnNullableSbyteMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableSbyteProperty);
            Expression<Func<EntityWithAllSupportedTypes, sbyte?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableSbyteArrayPropertyInCalculatorWhenComputeThenReturnNullableSbyteArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableSbyteArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<sbyte?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SBYTE_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingShortPropertyInCalculatorWhenComputeThenReturnShortMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.ShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingShortArrayPropertyInCalculatorWhenComputeThenReturnShortArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.ShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.SHORT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableShortPropertyInCalculatorWhenComputeThenReturnNullableShortMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableShortProperty);
            Expression<Func<EntityWithAllSupportedTypes, short?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableShortArrayPropertyInCalculatorWhenComputeThenReturnNullableShortArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableShortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<short?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_SHORT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUshortPropertyInCalculatorWhenComputeThenReturnUshortMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.UshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUshortArrayPropertyInCalculatorWhenComputeThenReturnUshortArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.UshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.USHORT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUshortPropertyInCalculatorWhenComputeThenReturnNullableUshortMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableUshortProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUshortArrayPropertyInCalculatorWhenComputeThenReturnNullableUshortArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableUshortArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_USHORT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingIntPropertyInCalculatorWhenComputeThenReturnIntMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.IntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingIntArrayPropertyInCalculatorWhenComputeThenReturnIntArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.IntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.INT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableIntPropertyInCalculatorWhenComputeThenReturnNullableIntMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableIntProperty);
            Expression<Func<EntityWithAllSupportedTypes, int?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableIntArrayPropertyInCalculatorWhenComputeThenReturnNullableIntArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableIntArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<int?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_INT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUintPropertyInCalculatorWhenComputeThenReturnUintMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.UintProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUintArrayPropertyInCalculatorWhenComputeThenReturnUintArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.UintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.UINT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUintPropertyInCalculatorWhenComputeThenReturnNullableUintMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableUintProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUintArrayPropertyInCalculatorWhenComputeThenReturnNullableUintArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableUintArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_UINT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingLongPropertyInCalculatorWhenComputeThenReturnLongMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.LongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingLongArrayPropertyInCalculatorWhenComputeThenReturnLongArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.LongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.LONG_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableLongPropertyInCalculatorWhenComputeThenReturnNullableLongMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableLongProperty);
            Expression<Func<EntityWithAllSupportedTypes, long?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableLongArrayPropertyInCalculatorWhenComputeThenReturnNullableLongArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableLongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<long?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_LONG_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUlongPropertyInCalculatorWhenComputeThenReturnUlongMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.UlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingUlongArrayPropertyInCalculatorWhenComputeThenReturnUlongArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.UlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ULONG_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUlongPropertyInCalculatorWhenComputeThenReturnNullableUlongMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableUlongProperty);
            Expression<Func<EntityWithAllSupportedTypes, ulong?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableUlongArrayPropertyInCalculatorWhenComputeThenReturnNullableUlongArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableUlongArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<ulong?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_ULONG_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingFloatPropertyInCalculatorWhenComputeThenReturnFloatMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.FloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingFloatArrayPropertyInCalculatorWhenComputeThenReturnFloatArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.FloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.FLOAT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableFloatPropertyInCalculatorWhenComputeThenReturnNullableFloatMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableFloatProperty);
            Expression<Func<EntityWithAllSupportedTypes, float?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableFloatArrayPropertyInCalculatorWhenComputeThenReturnNullableFloatArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableFloatArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<float?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_FLOAT_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDoublePropertyInCalculatorWhenComputeThenReturnDoubleMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.DoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDoubleArrayPropertyInCalculatorWhenComputeThenReturnDoubleArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.DoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DOUBLE_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDoublePropertyInCalculatorWhenComputeThenReturnNullableDoubleMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableDoubleProperty);
            Expression<Func<EntityWithAllSupportedTypes, double?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDoubleArrayPropertyInCalculatorWhenComputeThenReturnNullableDoubleArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableDoubleArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<double?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DOUBLE_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDecimalPropertyInCalculatorWhenComputeThenReturnDecimalMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.DecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDecimalArrayPropertyInCalculatorWhenComputeThenReturnDecimalArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.DecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DECIMAL_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDecimalPropertyInCalculatorWhenComputeThenReturnNullableDecimalMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableDecimalProperty);
            Expression<Func<EntityWithAllSupportedTypes, decimal?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDecimalArrayPropertyInCalculatorWhenComputeThenReturnNullableDecimalArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableDecimalArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<decimal?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DECIMAL_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDateTimePropertyInCalculatorWhenComputeThenReturnDateTimeMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.DateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingDateTimeArrayPropertyInCalculatorWhenComputeThenReturnDateTimeArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.DateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DATETIME_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDateTimePropertyInCalculatorWhenComputeThenReturnNullableDateTimeMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableDateTimeProperty);
            Expression<Func<EntityWithAllSupportedTypes, DateTime?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableDateTimeArrayPropertyInCalculatorWhenComputeThenReturnNullableDateTimeArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableDateTimeArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<DateTime?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_DATETIME_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingTimeSpanPropertyInCalculatorWhenComputeThenReturnTimeSpanMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.TimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnTimeSpanArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.TimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.TIMESPAN_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableTimeSpanPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableTimeSpanProperty);
            Expression<Func<EntityWithAllSupportedTypes, TimeSpan?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableTimeSpanArrayPropertyInCalculatorWhenComputeThenReturnNullableTimeSpanArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableTimeSpanArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<TimeSpan?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_TIMESPAN_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingCharPropertyInCalculatorWhenComputeThenReturnCharMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.CharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingCharArrayPropertyInCalculatorWhenComputeThenReturnCharArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.CharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHAR_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableCharPropertyInCalculatorWhenComputeThenReturnNullableCharMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableCharProperty);
            Expression<Func<EntityWithAllSupportedTypes, char?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableCharArrayPropertyInCalculatorWhenComputeThenReturnNullableCharArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableCharArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<char?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_CHAR_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyInCalculatorWhenComputeThenReturnNullableStringMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableStringProperty);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableStringProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.Using(e => e.NullableStringProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UNICODE_MD5, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, string>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression, Encoding.UTF32));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF8_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.Using(e => e.NullableStringProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_UTF32_MD5, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyInCalculatorWhenComputeThenReturnNullableStringArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyAndUnicodeEncodingInCalculatorWhenComputeThenReturnNullableStringArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.Unicode);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.Unicode;
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UNICODE_MD5, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingNullableStringArrayPropertyAndUTF32EncodingInCalculatorWhenComputeThenReturnNullableStringArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF32);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<string>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression, Encoding.Unicode));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty, Encoding.UTF8);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF8_MD5, actual);

            calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Context.Encoding = Encoding.UTF32;
            calculator.UsingEach(e => e.NullableStringArrayProperty);
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_STRING_ARRAY_UTF32_MD5, actual);

            return actual;
        }

        [Fact]
        public byte[] UsingGuidPropertyInCalculatorWhenComputeThenReturnGuidMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.GuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingGuidArrayPropertyInCalculatorWhenComputeThenReturnGuidArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.GuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.GUID_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableGuidPropertyInCalculatorWhenComputeThenReturnNullableGuidMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.NullableGuidProperty);
            Expression<Func<EntityWithAllSupportedTypes, Guid?>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingNullableGuidArrayPropertyInCalculatorWhenComputeThenReturnNullableGuidArrayMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.NullableGuidArrayProperty);
            Expression<Func<EntityWithAllSupportedTypes, IEnumerable<Guid?>>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.UsingEach(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.NULLABLE_GUID_ARRAY_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingComplexPropertyInCalculatorWhenComputeThenReturnEntityIdMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.Using(e => e.Child);
            Expression<Func<EntityWithAllSupportedTypes, Entity>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DEFAULT_MD5, actual);
            calculator.Using(e => e.Child).WithMD5(calc => calc.Using(e => e.Id));
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHILD_ENTITY_ID_MD5, actual);
            return actual;
        }

        [Fact]
        public byte[] UsingComplexListPropertyInCalculatorWhenComputeThenReturnEntityIdMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
            calculator.UsingEach(e => e.ChildList);
            Expression<Func<EntityWithAllSupportedTypes, Entity>> nullExpression = null;
            Assert.Throws<ArgumentNullException>(() => calculator.Using(nullExpression));
            var actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.DEFAULT_MD5, actual);
            calculator.UsingEach(e => e.ChildList).WithMD5(calc => calc.Using(e => e.Id));
            actual = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.CHILDLIST_ENTITY_ID_MD5, actual);
            return actual;
        }

        [Fact]
        public (byte[], byte[]) UsingAllPropertiesInCalculatorWhenComputeThenReturnMD5()
        {
            var calculator = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_MD5, actual);

            var actual2 = calculator.Compute(new EntityWithAllSupportedTypes());
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPES_MD5, actual2);

            var calculator2 = new AbstractHashCalculatorBuilder<EntityWithAllSupportedTypes>.MD5();
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
            Assert.Equal(Consts.ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_MD5, actual3);

            Assert.NotEqual(actual, actual3);

            return (actual, actual3);
        }
    }
}
