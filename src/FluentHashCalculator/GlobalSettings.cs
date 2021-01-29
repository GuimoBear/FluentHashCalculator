using System.Text;

namespace FluentHashCalculator
{
    public static class GlobalSettings
    {
        /// <summary>
        /// Indicates whether errors that occurred when capturing the values reported in Using and UsingEach will be ignore<br /><br />
        /// If the value is <strong>false</strong>, the exception will be thrown<br /><br />
        /// Default value is <strong>true</strong>
        /// </summary>
        public static bool IgnoreErrors { get; set; } = true;

        public static class StringSettings
        {
            /// <summary>
            /// The default encoding to serialize strings <br /><br />
            /// Default value is <strong>UTF8</strong>
            /// </summary>
            public static Encoding Encoding { get; set; } = Encoding.UTF8;
        }
    }
}
