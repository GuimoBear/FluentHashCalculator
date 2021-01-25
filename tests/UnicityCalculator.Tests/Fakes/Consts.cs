using System;

namespace UnicityCalculator.Tests.Fakes
{
    public static class Consts
    {
        public const bool BOOL_DEFAULT_VALUE = true;
        public static readonly bool? NULLABLE_BOOL_DEFAULT_VALUE = null;
        public const byte BYTE_DEFAULT_VALUE = 40;
        public static readonly byte? NULLABLE_BYTE_DEFAULT_VALUE = 126;
        public const sbyte SBYTE_DEFAULT_VALUE = -30;
        public static readonly sbyte? NULLABLE_SBYTE_DEFAULT_VALUE = -127;
        public const short SHORT_DEFAULT_VALUE = -3354;
        public static readonly short? NULLABLE_SHORT_DEFAULT_VALUE = null;
        public const ushort USHORT_DEFAULT_VALUE = 16442;
        public static readonly ushort? NULLABLE_USHORT_DEFAULT_VALUE = ushort.MaxValue;
        public const int INT_DEFAULT_VALUE = -3;
        public static readonly int? NULLABLE_INT_DEFAULT_VALUE = -556687;
        public const uint UINT_DEFAULT_VALUE = 45343745;
        public static readonly uint? NULLABLE_UINT_DEFAULT_VALUE = null;
        public const long LONG_DEFAULT_VALUE = 545646514187867;
        public static readonly long? NULLABLE_LONG_DEFAULT_VALUE = -6456544654655;
        public const ulong ULONG_DEFAULT_VALUE = 15619557357327;
        public static readonly ulong? NULLABLE_ULONG_DEFAULT_VALUE = null;
        public const float FLOAT_DEFAULT_VALUE = -124.154F;
        public static readonly float? NULLABLE_FLOAT_DEFAULT_VALUE = 57457.112F;
        public const double DOUBLE_DEFAULT_VALUE = 3576547654.157567;
        public static readonly double? NULLABLE_DOUBLE_DEFAULT_VALUE = null;
        public const decimal DECIMAL_DEFAULT_VALUE = -16876753575.5754m;
        public static readonly decimal? NULLABLE_DECIMAL_DEFAULT_VALUE = 65415674.245721m;
        public static readonly DateTime DATETIME_DEFAULT_VALUE = new DateTime(2001, 5, 8, 12, 15, 30, 554);
        public static readonly DateTime? NULLABLE_DATETIME_DEFAULT_VALUE = null;
        public static readonly TimeSpan TIMESPAN_DEFAULT_VALUE = TimeSpan.FromDays(3).Add(TimeSpan.FromHours(20));
        public static readonly TimeSpan? NULLABLE_TIMESPAN_DEFAULT_VALUE = TimeSpan.FromDays(5).Add(TimeSpan.FromHours(16).Add(TimeSpan.FromSeconds(33)));
        public const char CHAR_DEFAULT_VALUE = 'X';
        public static readonly char? NULLABLE_CHAR_DEFAULT_VALUE = '¬';
        public static readonly string? NULLABLE_STRING_DEFAULT_VALUE = "zkjsdfghkhjKHGHSGDFHJSGDHJGJHfgjhfgjhgdsjkfhijstnyh G4144545 5457";
        public static readonly Guid GUID_DEFAULT_VALUE = Guid.Parse("a6334475-7984-402a-85a8-fe7c33274756");
        public static readonly Guid? NULLABLE_GUID_DEFAULT_VALUE = null;


        public const ulong BOOL_CRC64 = 8851949072701294969;
        public const ulong NULLABLE_BOOL_CRC64 = 0;
        public const ulong BYTE_CRC64 = 1685075000233220297;
        public const ulong NULLABLE_BYTE_CRC64 = 8086654739370680208;
        public const ulong SBYTE_CRC64 = 10194834826163947140;
        public const ulong NULLABLE_SBYTE_CRC64 = 621185548802872648;
        public const ulong SHORT_CRC64 = 17124689223286266997;
        public const ulong NULLABLE_SHORT_CRC64 = 0;
        public const ulong USHORT_CRC64 = 2277623779326568124;
        public const ulong NULLABLE_USHORT_CRC64 = 8694046612813204184;
        public const ulong INT_CRC64 = 12678702243491284291;
        public const ulong NULLABLE_INT_CRC64 = 8097155797399412097;
        public const ulong UINT_CRC64 = 1182122151750750653;
        public const ulong NULLABLE_UINT_CRC64 = 0;
        public const ulong LONG_CRC64 = 5210827803641285055;
        public const ulong NULLABLE_LONG_CRC64 = 6381804994955514083;
        public const ulong ULONG_CRC64 = 2774443926609375248;
        public const ulong NULLABLE_ULONG_CRC64 = 0;
        public const ulong FLOAT_CRC64 = 16603323503518913904;
        public const ulong NULLABLE_FLOAT_CRC64 = 4221985640318236758;
        public const ulong DOUBLE_CRC64 = 10926962147394137679;
        public const ulong NULLABLE_DOUBLE_CRC64 = 0;
        public const ulong DECIMAL_CRC64 = 14918519836982787174;
        public const ulong NULLABLE_DECIMAL_CRC64 = 3210317024736405031;
        public const ulong DATETIME_CRC64 = 822551463959853570;
        public const ulong NULLABLE_DATETIME_CRC64 = 0;
        public const ulong TIMESPAN_CRC64 = 12716245390639207035;
        public const ulong NULLABLE_TIMESPAN_CRC64 = 2194447488117626623;
        public const ulong CHAR_CRC64 = 14766541453587187574;
        public const ulong NULLABLE_CHAR_CRC64 = 14895109130451914418;
        public const ulong NULLABLE_STRING_CRC64 = 1468224749002807263;
        public const ulong GUID_CRC64 = 5568896784530736226;
        public const ulong NULLABLE_GUID_CRC64 = 0;


        public const ulong ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC64 = 13947785489894356902;

        public const ulong ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC64 = 3495469619359939619;

        //;
    }
}
