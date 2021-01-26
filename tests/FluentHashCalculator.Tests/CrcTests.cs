using FluentHashCalculator.Internal;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class CrcTests
    {
        [Fact]
        public void UsingAnEmptyByteArrayWhenComputeCRC64ThenReturns0()
        {
            ulong expected = 0;
            var actual = Crc64.Compute(new byte[0]);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnEmptyByteArrayAnd8IncrcWhenComputeCRC64ThenReturns0()
        {
            ulong expected = 8;
            var actual = Crc64.Compute(new byte[0], expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayWhenComputeCRC64ThenReturns0()
        {
            ulong expected = 0;
            var actual = Crc64.Compute(null);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayAnd8IncrcWhenComputeCRC64ThenReturns0()
        {
            ulong expected = 8;
            var actual = Crc64.Compute(null, expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnOneElementByteArrayWhenComputeCRC64ThenReturns()
        {
            ulong expected = 17703898145402589938;
            var actual = Crc64.Compute(new byte[] { 2 });

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnEmptyByteArrayWhenComputeCRC32ThenReturns0()
        {
            uint expected = 0;
            var actual = Crc32.Compute(new byte[0]);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnEmptyByteArrayAnd8IncrcWhenComputeCRC32ThenReturns0()
        {
            uint expected = 8;
            var actual = Crc32.Compute(new byte[0], expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayWhenComputeCRC32ThenReturns0()
        {
            uint expected = 0;
            var actual = Crc32.Compute(null);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayAnd8IncrcWhenComputeCRC32ThenReturns0()
        {
            uint expected = 8;
            var actual = Crc32.Compute(null, expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnOneElementByteArrayWhenComputeCRC32ThenReturns()
        {
            uint expected = 3993919788;
            var actual = Crc32.Compute(new byte[] { 2 });

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnEmptyByteArrayWhenComputeCRC16ThenReturns0()
        {
            ushort expected = 0;
            var actual = Crc16.Compute(new byte[0]);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnEmptyByteArrayAnd8IncrcWhenComputeCRC16ThenReturns0()
        {
            ushort expected = 8;
            var actual = Crc16.Compute(new byte[0], expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayWhenComputeCRC16ThenReturns0()
        {
            ushort expected = 0;
            var actual = Crc16.Compute(null);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnNullByteArrayAnd8IncrcWhenComputeCRC16ThenReturns0()
        {
            ushort expected = 8;
            var actual = Crc16.Compute(null, expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingAnOneElementByteArrayWhenComputeCRC16ThenReturns()
        {
            ushort expected = 8258;
            var actual = Crc16.Compute(new byte[] { 2 });

            Assert.Equal(expected, actual);
        }
    }
}
