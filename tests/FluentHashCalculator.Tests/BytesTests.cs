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
            Assert.Throws<TypeNotSupportedException>(() => Bytes.From(new Entity(), new Contexts.SerializationContext()).ToList());
        }

        [Fact]
        public void UsingAnNotSupportedTypeAndSupressExceptionWhenCallFromMethodReturnAnEmptyByteArray()
        {
            Assert.Empty(Bytes.From(new Entity(), new Contexts.SerializationContext(), true).ToList());
        }
    }
}
