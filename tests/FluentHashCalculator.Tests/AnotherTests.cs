using System;
using System.Text;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class AnotherTests
    {
        [Fact]
        public void ValidateGlobalSettings()
        {
            GlobalSettings.IgnoreErrors = true;

            GlobalSettings.StringSettings.Encoding = Encoding.UTF8;
        }

        [Fact]
        public void UsingAnMessageAndAnFormatExceptionWhenConstructCrcExceptionThenNotThrowAnyException()
        {
            new CrcException("", new FormatException());
        }

        [Fact]
        public void UsingAnMessageAndAnInvalidCastExceptionWhenConstructCrcExceptionThenNotThrowAnyException()
        {
            new CrcException("", new InvalidCastException());
        }

        [Fact]
        public void UsingAnMessageAndAnOverflowExceptionWhenConstructCrcExceptionThenNotThrowAnyException()
        {
            new CrcException("", new OverflowException());
        }
    }
}
