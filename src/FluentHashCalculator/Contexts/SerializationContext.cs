using System.Text;

namespace FluentHashCalculator.Contexts
{
    public class SerializationContext : IStringSerializationContext
    {
        /// <summary>
        /// The encoding to serialize this string property <br /><br />
        /// Default value is <strong>GlobalSettings.StringSettings.Encoding</strong>
        /// </summary>
        public Encoding Encoding { get; set; } = GlobalSettings.StringSettings.Encoding;

        /// <summary>
        /// Indicates whether errors that occurred when capturing the values reported in Using and UsingEach will be ignore<br /><br />
        /// If the value is <strong>false</strong>, the exception will be thrown<br /><br />
        /// Default value is <strong>GlobalSettings.IgnoreErrors</strong>
        /// </summary>
        public bool IgnoreErrors { get; set; } = GlobalSettings.IgnoreErrors;
    }
}
