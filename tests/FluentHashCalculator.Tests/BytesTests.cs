using FluentHashCalculator.Internal;
using FluentHashCalculator.Tests.Fakes;
using System.Linq;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class BytesTests
    {
        [Fact]
        public void UsingAnNotSupportedTypeAndNotSupressExceptionWhenCallFromMethodThrowTypeNotSupportedException()
        {
            Assert.Throws<TypeNotSupportedException>(() => Bytes.From(new Entity()).ToList());
        }

        [Fact]
        public void UsingAnNotSupportedTypeAndSupressExceptionWhenCallFromMethodReturnAnEmptyByteArray()
        {
            Assert.Empty(Bytes.From(new Entity(), true).ToList());
        }
    }
}
