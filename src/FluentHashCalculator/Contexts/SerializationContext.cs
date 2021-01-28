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
    }
}
