using System;

namespace UnicityCalculator.Tests.Fakes
{
    public class EntityWithAllSupportedTypes
    {
        public bool BoolProperty { get; } = Consts.BOOL_DEFAULT_VALUE;
        public bool? NullableBoolProperty { get; } = Consts.NULLABLE_BOOL_DEFAULT_VALUE;
        public byte ByteProperty { get; } = Consts.BYTE_DEFAULT_VALUE;
        public byte? NullableByteProperty { get; } = Consts.NULLABLE_BYTE_DEFAULT_VALUE;
        public sbyte SbyteProperty { get; } = Consts.SBYTE_DEFAULT_VALUE;
        public sbyte? NullableSbyteProperty { get; } = Consts.NULLABLE_SBYTE_DEFAULT_VALUE;
        public short ShortProperty { get; } = Consts.SHORT_DEFAULT_VALUE;
        public short? NullableShortProperty { get; } = Consts.NULLABLE_SHORT_DEFAULT_VALUE;
        public ushort UshortProperty { get; } = Consts.USHORT_DEFAULT_VALUE;
        public ushort? NullableUshortProperty { get; } = Consts.NULLABLE_USHORT_DEFAULT_VALUE;
        public int IntProperty { get; } = Consts.INT_DEFAULT_VALUE;
        public int? NullableIntProperty { get; } = Consts.NULLABLE_INT_DEFAULT_VALUE;
        public uint UintProperty { get; } = Consts.UINT_DEFAULT_VALUE;
        public uint? NullableUintProperty { get; } = Consts.NULLABLE_UINT_DEFAULT_VALUE;
        public long LongProperty { get; } = Consts.LONG_DEFAULT_VALUE;
        public long? NullableLongProperty { get; } = Consts.NULLABLE_LONG_DEFAULT_VALUE;
        public ulong UlongProperty { get; } = Consts.ULONG_DEFAULT_VALUE;
        public ulong? NullableUlongProperty { get; } = Consts.NULLABLE_ULONG_DEFAULT_VALUE;
        public float FloatProperty { get; } = Consts.FLOAT_DEFAULT_VALUE;
        public float? NullableFloatProperty { get; } = Consts.NULLABLE_FLOAT_DEFAULT_VALUE;
        public double DoubleProperty { get; } = Consts.DOUBLE_DEFAULT_VALUE;
        public double? NullableDoubleProperty { get; } = Consts.NULLABLE_DOUBLE_DEFAULT_VALUE;
        public decimal DecimalProperty { get; } = Consts.DECIMAL_DEFAULT_VALUE;
        public decimal? NullableDecimalProperty { get; } = Consts.NULLABLE_DECIMAL_DEFAULT_VALUE;
        public DateTime DateTimeProperty { get; } = Consts.DATETIME_DEFAULT_VALUE;
        public DateTime? NullableDateTimeProperty { get; } = Consts.NULLABLE_DATETIME_DEFAULT_VALUE;
        public TimeSpan TimeSpanProperty { get; } = Consts.TIMESPAN_DEFAULT_VALUE;
        public TimeSpan? NullableTimeSpanProperty { get; } = Consts.NULLABLE_TIMESPAN_DEFAULT_VALUE;
        public char CharProperty { get; } = Consts.CHAR_DEFAULT_VALUE;
        public char? NullableCharProperty { get; } = Consts.NULLABLE_CHAR_DEFAULT_VALUE;
        public string? NullableStringProperty { get; } = Consts.NULLABLE_STRING_DEFAULT_VALUE;
        public Guid GuidProperty { get; } = Consts.GUID_DEFAULT_VALUE;
        public Guid? NullableGuidProperty { get; } = Consts.NULLABLE_GUID_DEFAULT_VALUE;
    }
}
