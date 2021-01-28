using System.Text;

namespace FluentHashCalculator.Contexts
{
    public interface IStringSerializationContext
    {
        /// <summary>
        /// The encoding to serialize this string property
        /// </summary>
        Encoding Encoding { get; }
    }
}
