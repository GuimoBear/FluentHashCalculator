using System;
using System.Collections.Generic;

namespace FluentHashCalculator.Tests.Fakes
{
    public static class Consts
    {
        #region Valores padrão para todos os tipos suportados
        public const bool BOOL_DEFAULT_VALUE = true;
        public static readonly bool[] BOOL_ARRAY_DEFAULT_VALUE = new bool[] { true, false, true };
        public static readonly bool? NULLABLE_BOOL_DEFAULT_VALUE = null;
        public static readonly bool?[] NULLABLE_BOOL_ARRAY_DEFAULT_VALUE = new bool?[] { false, null, true };
        public const byte BYTE_DEFAULT_VALUE = 40;
        public static readonly IEnumerable<byte> BYTE_ARRAY_DEFAULT_VALUE = new byte[] { 40, 128, 255 };
        public static readonly byte? NULLABLE_BYTE_DEFAULT_VALUE = 126;
        public static readonly IEnumerable<byte?> NULLABLE_BYTE_ARRAY_DEFAULT_VALUE = new byte?[] { 22, null, 84, 2, 221 };
        public const sbyte SBYTE_DEFAULT_VALUE = -30;
        public static readonly ICollection<sbyte> SBYTE_ARRAY_DEFAULT_VALUE = new List<sbyte> { -30, 1, -55, 69 };
        public static readonly sbyte? NULLABLE_SBYTE_DEFAULT_VALUE = -127;
        public static readonly ICollection<sbyte?> NULLABLE_SBYTE_ARRAY_DEFAULT_VALUE = new List<sbyte?> { -127, 55, null, -5, 122 };
        public const short SHORT_DEFAULT_VALUE = -3354;
        public static readonly IList<short> SHORT_ARRAY_DEFAULT_VALUE = new List<short> { -3354, 8445, -32551 };
        public static readonly short? NULLABLE_SHORT_DEFAULT_VALUE = null;
        public static readonly IList<short?> NULLABLE_SHORT_ARRAY_DEFAULT_VALUE = new List<short?> { 25445, null, 112, -5443, 1038 };
        public const ushort USHORT_DEFAULT_VALUE = 16442;
        public static readonly IReadOnlyCollection<ushort> USHORT_ARRAY_DEFAULT_VALUE = new List<ushort> { 16442, 4487, 3, 254 };
        public static readonly ushort? NULLABLE_USHORT_DEFAULT_VALUE = ushort.MaxValue;
        public static readonly IReadOnlyCollection<ushort?> NULLABLE_USHORT_ARRAY_DEFAULT_VALUE = new List<ushort?> { 65534, 3, 15547 };
        public const int INT_DEFAULT_VALUE = -3;
        public static readonly IReadOnlyList<int> INT_ARRAY_DEFAULT_VALUE = new List<int> { -3, -98735757, 3573541, 554 };
        public static readonly int? NULLABLE_INT_DEFAULT_VALUE = -556687;
        public static readonly IReadOnlyList<int?> NULLABLE_INT_ARRAY_DEFAULT_VALUE = new List<int?> { -556687, -16556735, 55893544, null, 47457 };
        public const uint UINT_DEFAULT_VALUE = 45343745;
        public static readonly IReadOnlySet<uint> UINT_ARRAY_DEFAULT_VALUE = new HashSet<uint> { 25343745, 35745373, 9984 };
        public static readonly uint? NULLABLE_UINT_DEFAULT_VALUE = null;
        public static readonly IReadOnlySet<uint?> NULLABLE_UINT_ARRAY_DEFAULT_VALUE = new HashSet<uint?> { 2424, null };
        public const long LONG_DEFAULT_VALUE = 545646514187867;
        public static readonly IEnumerable<long> LONG_ARRAY_DEFAULT_VALUE = new long[] { 3575331354, 31687785242, -31243357435, 8454 };
        public static readonly long? NULLABLE_LONG_DEFAULT_VALUE = -6456544654655;
        public static readonly IEnumerable<long?> NULLABLE_LONG_ARRAY_DEFAULT_VALUE = new long?[] { null, -6456544654655, null, 768743573524 };
        public const ulong ULONG_DEFAULT_VALUE = 15619557357327;
        public static readonly IEnumerable<ulong> ULONG_ARRAY_DEFAULT_VALUE = new ulong[] { 15619557357327, 35435734 };
        public static readonly ulong? NULLABLE_ULONG_DEFAULT_VALUE = null;
        public static readonly IEnumerable<ulong?> NULLABLE_ULONG_ARRAY_DEFAULT_VALUE = new ulong?[] { 84198594, 4247524775, null };
        public const float FLOAT_DEFAULT_VALUE = -124.154F;
        public static readonly IEnumerable<float> FLOAT_ARRAY_DEFAULT_VALUE = new float[] { -124.154F, -552381.57445F, 23789.3541F, 32 };
        public static readonly float? NULLABLE_FLOAT_DEFAULT_VALUE = 57457.112F;
        public static readonly IEnumerable<float?> NULLABLE_FLOAT_ARRAY_DEFAULT_VALUE = new float?[] { 57457.112F, null, -6376545.3114F };
        public const double DOUBLE_DEFAULT_VALUE = 3576547654.157567;
        public static readonly IEnumerable<double> DOUBLE_ARRAY_DEFAULT_VALUE = new double[] { 3576547654.157567, -157457.3325 };
        public static readonly double? NULLABLE_DOUBLE_DEFAULT_VALUE = null;
        public static readonly IEnumerable<double?> NULLABLE_DOUBLE_ARRAY_DEFAULT_VALUE = new double?[] { null };
        public const decimal DECIMAL_DEFAULT_VALUE = -16876753575.5754m;
        public static readonly IEnumerable<decimal> DECIMAL_ARRAY_DEFAULT_VALUE = new decimal[] { 3366874157741.84154m, -16876753575.5754m };
        public static readonly decimal? NULLABLE_DECIMAL_DEFAULT_VALUE = 65415674.245721m;
        public static readonly IEnumerable<decimal?> NULLABLE_DECIMAL_ARRAY_DEFAULT_VALUE = new decimal?[] { 65415674.245721m, null, -33547889 };
        public static readonly DateTime DATETIME_DEFAULT_VALUE = new DateTime(2001, 5, 8, 12, 15, 30, 554);
        public static readonly IEnumerable<DateTime> DATETIME_ARRAY_DEFAULT_VALUE = new DateTime[] { new DateTime(2001, 5, 8, 12, 15, 30, 554), new DateTime(1977, 8, 3, 7, 1, 39, 447) };
        public static readonly DateTime? NULLABLE_DATETIME_DEFAULT_VALUE = null;
        public static readonly IEnumerable<DateTime?> NULLABLE_DATETIME_ARRAY_DEFAULT_VALUE = null;
        public static readonly TimeSpan TIMESPAN_DEFAULT_VALUE = TimeSpan.FromDays(3).Add(TimeSpan.FromHours(20));
        public static readonly IEnumerable<TimeSpan> TIMESPAN_ARRAY_DEFAULT_VALUE = new List<TimeSpan> { TimeSpan.FromDays(3).Add(TimeSpan.FromHours(20)), TimeSpan.Zero };
        public static readonly TimeSpan? NULLABLE_TIMESPAN_DEFAULT_VALUE = TimeSpan.FromDays(5).Add(TimeSpan.FromHours(16).Add(TimeSpan.FromSeconds(33)));
        public static readonly IEnumerable<TimeSpan?> NULLABLE_TIMESPAN_ARRAY_DEFAULT_VALUE = new TimeSpan?[] { null, TimeSpan.FromDays(5).Add(TimeSpan.FromHours(16).Add(TimeSpan.FromSeconds(33))) };
        public const char CHAR_DEFAULT_VALUE = 'X';
        public static readonly IEnumerable<char> CHAR_ARRAY_DEFAULT_VALUE = new char[] { 'x', ' ', '¬' };
        public static readonly char? NULLABLE_CHAR_DEFAULT_VALUE = '¬';
        public static readonly IEnumerable<char?> NULLABLE_CHAR_ARRAY_DEFAULT_VALUE = new char?[] { '¬', null, '´' };
        public static readonly string? NULLABLE_STRING_DEFAULT_VALUE = "zkjsdfghkhjKHGHSGDFHJSGDHJGJHfgjhfgjhgdsjkfhijstnyh G4144545 5457";
        public static readonly IEnumerable<string?> NULLABLE_STRING_ARRAY_DEFAULT_VALUE = new List<string?> { "sdkl.jgfuwehfioefw6ef4w564f5we745f7w 6sd8486dm7468.74l8k7ç687lk687.kççklçk", "adsklfyhli4lk4lj3h5345454fd5s4 5 4f5g4 f5dg454f5g ", null };
        public static readonly Guid GUID_DEFAULT_VALUE = Guid.Parse("a6334475-7984-402a-85a8-fe7c33274756");
        public static readonly IEnumerable<Guid> GUID_ARRAY_DEFAULT_VALUE = new Guid[] { Guid.Parse("a6334475-7984-402a-85a8-fe7c33274756"), Guid.Empty, Guid.Parse("c0bcefe4-367e-49b6-aceb-e08be2c90c07") };
        public static readonly Guid? NULLABLE_GUID_DEFAULT_VALUE = null;
        public static readonly IEnumerable<Guid?> NULLABLE_GUID_ARRAY_DEFAULT_VALUE = new Guid?[] { null, Guid.Empty, Guid.Parse("bf379fa4-b7e6-4dbe-8e75-720857c82a61") };
        #endregion

        #region Valores dos CRC64 dos valores padrão
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

        public const ulong ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC64 = 4500183182751816844;
        public const ulong ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC64 = 14626739440370024875;
        #endregion

        #region Valores dos CRC32 dos valores padrão
        public const uint BOOL_CRC32 = 1996959894;
        public const uint NULLABLE_BOOL_CRC32 = 0;
        public const uint BYTE_CRC32 = 1566420650;
        public const uint NULLABLE_BYTE_CRC32 = 2981909624;
        public const uint SBYTE_CRC32 = 1095401187;
        public const uint NULLABLE_SBYTE_CRC32 = 261768839;
        public const uint SHORT_CRC32 = 1536673626;
        public const uint NULLABLE_SHORT_CRC32 = 0;
        public const uint USHORT_CRC32 = 1400217577;
        public const uint NULLABLE_USHORT_CRC32 = 3190166271;
        public const uint INT_CRC32 = 1957881960;
        public const uint NULLABLE_INT_CRC32 = 1166749369;
        public const uint UINT_CRC32 = 934380366;
        public const uint NULLABLE_UINT_CRC32 = 0;
        public const uint LONG_CRC32 = 510828597;
        public const uint NULLABLE_LONG_CRC32 = 2245717139;
        public const uint ULONG_CRC32 = 882806755;
        public const uint NULLABLE_ULONG_CRC32 = 0;
        public const uint FLOAT_CRC32 = 2287443696;
        public const uint NULLABLE_FLOAT_CRC32 = 2047161009;
        public const uint DOUBLE_CRC32 = 3842055048;
        public const uint NULLABLE_DOUBLE_CRC32 = 0;
        public const uint DECIMAL_CRC32 = 1397372455;
        public const uint NULLABLE_DECIMAL_CRC32 = 3849990572;
        public const uint DATETIME_CRC32 = 4237563156;
        public const uint NULLABLE_DATETIME_CRC32 = 0;
        public const uint TIMESPAN_CRC32 = 1844422342;
        public const uint NULLABLE_TIMESPAN_CRC32 = 744291154;
        public const uint CHAR_CRC32 = 1919080284;
        public const uint NULLABLE_CHAR_CRC32 = 45282277;
        public const uint NULLABLE_STRING_CRC32 = 3736583002;
        public const uint GUID_CRC32 = 2134131087;
        public const uint NULLABLE_GUID_CRC32 = 0;

        public const uint ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC32 = 2799024604;
        public const uint ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC32 = 3449237014;
        #endregion

        #region Valores dos CRC16 dos valores padrão
        public const uint BOOL_CRC16 = 4129;
        public const uint NULLABLE_BOOL_CRC16 = 0;
        public const uint BYTE_CRC16 = 52553;
        public const uint NULLABLE_BYTE_CRC16 = 52035;
        public const uint SBYTE_CRC16 = 45831;
        public const uint NULLABLE_SBYTE_CRC16 = 15026;
        public const uint SHORT_CRC16 = 46054;
        public const uint NULLABLE_SHORT_CRC16 = 0;
        public const uint USHORT_CRC16 = 52043;
        public const uint NULLABLE_USHORT_CRC16 = 61937;
        public const uint INT_CRC16 = 53560;
        public const uint NULLABLE_INT_CRC16 = 7844;
        public const uint UINT_CRC16 = 20556;
        public const uint NULLABLE_UINT_CRC16 = 0;
        public const uint LONG_CRC16 = 61428;
        public const uint NULLABLE_LONG_CRC16 = 15975;
        public const uint ULONG_CRC16 = 56311;
        public const uint NULLABLE_ULONG_CRC16 = 0;
        public const uint FLOAT_CRC16 = 29853;
        public const uint NULLABLE_FLOAT_CRC16 = 37133;
        public const uint DOUBLE_CRC16 = 36188;
        public const uint NULLABLE_DOUBLE_CRC16 = 0;
        public const uint DECIMAL_CRC16 = 45421;
        public const uint NULLABLE_DECIMAL_CRC16 = 61891;
        public const uint DATETIME_CRC16 = 61702;
        public const uint NULLABLE_DATETIME_CRC16 = 0;
        public const uint TIMESPAN_CRC16 = 16935;
        public const uint NULLABLE_TIMESPAN_CRC16 = 54628;
        public const uint CHAR_CRC16 = 15977;
        public const uint NULLABLE_CHAR_CRC16 = 3092;
        public const uint NULLABLE_STRING_CRC16 = 20178;
        public const uint GUID_CRC16 = 42306;
        public const uint NULLABLE_GUID_CRC16 = 0;

        public const ushort ENTITY_WITH_ALL_SUPPORTED_TYPES_CRC16 = 7197;
        public const ushort ENTITY_WITH_ALL_SUPPORTED_TYPESBUT_WITH_NO_UINT_PROPERTY_CRC16 = 2781;
        #endregion
    }
}
