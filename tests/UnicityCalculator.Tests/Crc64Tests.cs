using UnicityCalculator.Internal;
using Xunit;

namespace UnicityCalculator.Tests
{
    public class Crc64Tests
    {
        [Fact]
        public void UsingAnEmptyByteArrayWhenComputeThenReturns0()
        {
            ulong expected = 0;
            var actual = Crc64.Compute(new byte[0]);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnEmptyByteArrayAnd8IncrcWhenComputeThenReturns0()
        {
            ulong expected = 8;
            var actual = Crc64.Compute(new byte[0], expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayWhenComputeThenReturns0()
        {
            ulong expected = 0;
            var actual = Crc64.Compute(null);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayAnd8IncrcWhenComputeThenReturns0()
        {
            ulong expected = 8;
            var actual = Crc64.Compute(null, expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnOneElementByteArrayWhenComputeThenReturns()
        {
            ulong expected = 17703898145402589938;
            var actual = Crc64.Compute(new byte[] { 2 });

            Assert.Equal(expected, actual);
        }
    }
}
