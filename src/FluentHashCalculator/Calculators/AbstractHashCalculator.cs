using System.Text;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculator<T>
        where T: class
    {
        protected abstract IAbstractHashCalculatorBuilder<T> Calculate { get; }

        /// <summary>
        /// The encoding to serialize strings in this AbstractHashCalculator <br /><br />
        /// Default value is <strong>GlobalSettings.StringSettings.Encoding</strong>
        /// </summary>
        public Encoding Encoding
        {
            get => Calculate.Context.Encoding;
            set => Calculate.Context.Encoding = value;
        }
    }
}
