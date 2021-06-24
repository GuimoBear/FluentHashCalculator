using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentHashCalculator.Benchmark
{
    public class Entity
    {
        public bool BoolProperty { get; } = Consts.BOOL_DEFAULT_VALUE;
        public bool[] BoolArrayProperty { get; } = Consts.BOOL_ARRAY_DEFAULT_VALUE;
        public bool? NullableBoolProperty { get; } = Consts.NULLABLE_BOOL_DEFAULT_VALUE;
        public bool?[] NullableBoolArrayProperty { get; } = Consts.NULLABLE_BOOL_ARRAY_DEFAULT_VALUE;
        public byte ByteProperty { get; } = Consts.BYTE_DEFAULT_VALUE;
        public IEnumerable<byte> ByteArrayProperty { get; } = Consts.BYTE_ARRAY_DEFAULT_VALUE;
        public byte? NullableByteProperty { get; } = Consts.NULLABLE_BYTE_DEFAULT_VALUE;
        public IEnumerable<byte?> NullableByteArrayProperty { get; } = Consts.NULLABLE_BYTE_ARRAY_DEFAULT_VALUE;
        public sbyte SbyteProperty { get; } = Consts.SBYTE_DEFAULT_VALUE;
        public ICollection<sbyte> SbyteArrayProperty { get; } = Consts.SBYTE_ARRAY_DEFAULT_VALUE;
        public sbyte? NullableSbyteProperty { get; } = Consts.NULLABLE_SBYTE_DEFAULT_VALUE;
        public ICollection<sbyte?> NullableSbyteArrayProperty { get; } = Consts.NULLABLE_SBYTE_ARRAY_DEFAULT_VALUE;
        public short ShortProperty { get; } = Consts.SHORT_DEFAULT_VALUE;
        public IList<short> ShortArrayProperty { get; } = Consts.SHORT_ARRAY_DEFAULT_VALUE;
        public short? NullableShortProperty { get; } = Consts.NULLABLE_SHORT_DEFAULT_VALUE;
        public IList<short?> NullableShortArrayProperty { get; } = Consts.NULLABLE_SHORT_ARRAY_DEFAULT_VALUE;
        public ushort UshortProperty { get; } = Consts.USHORT_DEFAULT_VALUE;
        public IReadOnlyCollection<ushort> UshortArrayProperty { get; } = Consts.USHORT_ARRAY_DEFAULT_VALUE;
        public ushort? NullableUshortProperty { get; } = Consts.NULLABLE_USHORT_DEFAULT_VALUE;
        public IReadOnlyCollection<ushort?> NullableUshortArrayProperty { get; } = Consts.NULLABLE_USHORT_ARRAY_DEFAULT_VALUE;
        public int IntProperty { get; } = Consts.INT_DEFAULT_VALUE;
        public IReadOnlyList<int> IntArrayProperty { get; } = Consts.INT_ARRAY_DEFAULT_VALUE;
        public int? NullableIntProperty { get; } = Consts.NULLABLE_INT_DEFAULT_VALUE;
        public IReadOnlyList<int?> NullableIntArrayProperty { get; } = Consts.NULLABLE_INT_ARRAY_DEFAULT_VALUE;
        public uint UintProperty { get; } = Consts.UINT_DEFAULT_VALUE;
        public IEnumerable<uint> UintArrayProperty { get; } = Consts.UINT_ARRAY_DEFAULT_VALUE;
        public uint? NullableUintProperty { get; } = Consts.NULLABLE_UINT_DEFAULT_VALUE;
        public IEnumerable<uint?> NullableUintArrayProperty { get; } = Consts.NULLABLE_UINT_ARRAY_DEFAULT_VALUE;
        public long LongProperty { get; } = Consts.LONG_DEFAULT_VALUE;
        public IEnumerable<long> LongArrayProperty { get; } = Consts.LONG_ARRAY_DEFAULT_VALUE;
        public long? NullableLongProperty { get; } = Consts.NULLABLE_LONG_DEFAULT_VALUE;
        public IEnumerable<long?> NullableLongArrayProperty { get; } = Consts.NULLABLE_LONG_ARRAY_DEFAULT_VALUE;
        public ulong UlongProperty { get; } = Consts.ULONG_DEFAULT_VALUE;
        public IEnumerable<ulong> UlongArrayProperty { get; } = Consts.ULONG_ARRAY_DEFAULT_VALUE;
        public ulong? NullableUlongProperty { get; } = Consts.NULLABLE_ULONG_DEFAULT_VALUE;
        public IEnumerable<ulong?> NullableUlongArrayProperty { get; } = Consts.NULLABLE_ULONG_ARRAY_DEFAULT_VALUE;
        public float FloatProperty { get; } = Consts.FLOAT_DEFAULT_VALUE;
        public IEnumerable<float> FloatArrayProperty { get; } = Consts.FLOAT_ARRAY_DEFAULT_VALUE;
        public float? NullableFloatProperty { get; } = Consts.NULLABLE_FLOAT_DEFAULT_VALUE;
        public IEnumerable<float?> NullableFloatArrayProperty { get; } = Consts.NULLABLE_FLOAT_ARRAY_DEFAULT_VALUE;
        public double DoubleProperty { get; } = Consts.DOUBLE_DEFAULT_VALUE;
        public IEnumerable<double> DoubleArrayProperty { get; } = Consts.DOUBLE_ARRAY_DEFAULT_VALUE;
        public double? NullableDoubleProperty { get; } = Consts.NULLABLE_DOUBLE_DEFAULT_VALUE;
        public IEnumerable<double?> NullableDoubleArrayProperty { get; } = Consts.NULLABLE_DOUBLE_ARRAY_DEFAULT_VALUE;
        public decimal DecimalProperty { get; } = Consts.DECIMAL_DEFAULT_VALUE;
        public IEnumerable<decimal> DecimalArrayProperty { get; } = Consts.DECIMAL_ARRAY_DEFAULT_VALUE;
        public decimal? NullableDecimalProperty { get; } = Consts.NULLABLE_DECIMAL_DEFAULT_VALUE;
        public IEnumerable<decimal?> NullableDecimalArrayProperty { get; } = Consts.NULLABLE_DECIMAL_ARRAY_DEFAULT_VALUE;
        public DateTime DateTimeProperty { get; } = Consts.DATETIME_DEFAULT_VALUE;
        public IEnumerable<DateTime> DateTimeArrayProperty { get; } = Consts.DATETIME_ARRAY_DEFAULT_VALUE;
        public DateTime? NullableDateTimeProperty { get; } = Consts.NULLABLE_DATETIME_DEFAULT_VALUE;
        public IEnumerable<DateTime?> NullableDateTimeArrayProperty { get; } = Consts.NULLABLE_DATETIME_ARRAY_DEFAULT_VALUE;
        public TimeSpan TimeSpanProperty { get; } = Consts.TIMESPAN_DEFAULT_VALUE;
        public IEnumerable<TimeSpan> TimeSpanArrayProperty { get; } = Consts.TIMESPAN_ARRAY_DEFAULT_VALUE;
        public TimeSpan? NullableTimeSpanProperty { get; } = Consts.NULLABLE_TIMESPAN_DEFAULT_VALUE;
        public IEnumerable<TimeSpan?> NullableTimeSpanArrayProperty { get; } = Consts.NULLABLE_TIMESPAN_ARRAY_DEFAULT_VALUE;
        public char CharProperty { get; } = Consts.CHAR_DEFAULT_VALUE;
        public IEnumerable<char> CharArrayProperty { get; } = Consts.CHAR_ARRAY_DEFAULT_VALUE;
        public char? NullableCharProperty { get; } = Consts.NULLABLE_CHAR_DEFAULT_VALUE;
        public IEnumerable<char?> NullableCharArrayProperty { get; } = Consts.NULLABLE_CHAR_ARRAY_DEFAULT_VALUE;
        public string NullableStringProperty { get; } = Consts.NULLABLE_STRING_DEFAULT_VALUE;
        public IEnumerable<string> NullableStringArrayProperty { get; } = Consts.NULLABLE_STRING_ARRAY_DEFAULT_VALUE;
        public Guid GuidProperty { get; } = Consts.GUID_DEFAULT_VALUE;
        public IEnumerable<Guid> GuidArrayProperty { get; } = Consts.GUID_ARRAY_DEFAULT_VALUE;
        public Guid? NullableGuidProperty { get; } = Consts.NULLABLE_GUID_DEFAULT_VALUE;
        public IEnumerable<Guid?> NullableGuidArrayProperty { get; } = Consts.NULLABLE_GUID_ARRAY_DEFAULT_VALUE;

        public Entity Child { get; }
        public IEnumerable<Entity> ChildList { get; }

        public Entity() { }
        private Entity(bool createChildInstance)
        {
            if (createChildInstance)
            {
                Child = new Entity(false);
                ChildList = new List<Entity> { new Entity(false) };
            }
            else
            {
                ChildList = new List<Entity> {  };
            }
        }
    }
}
