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
            protected set => Calculate.Context.Encoding = value;
        }

        /// <summary>
        /// Indicates whether errors that occurred when capturing the values reported in Using and UsingEach will be ignore<br /><br />
        /// If the value is <strong>false</strong>, the exception will be thrown<br /><br />
        /// Default value is <strong>GlobalSettings.IgnoreErrors</strong>
        /// </summary>
        public bool IgnoreErrors
        {
            get => Calculate.Context.IgnoreErrors;
            protected set => Calculate.Context.IgnoreErrors = value;
        }
    }
}
