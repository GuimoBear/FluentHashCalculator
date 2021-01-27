using FluentAssertions;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class AbstractHashCalculatorTests
    {
        [Fact]
        public void UsingAnValidInstanceWhenCRC64ComputeCallThenNotThrowAnyException()
        {
            var calculator = new CRC64EntityUnicityCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new System.DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Compute(instance);

            calculator.Compute(null)
                .Should().Be(ulong.MinValue);
        }

        [Fact]
        public void UsingAnValidInstanceWhenCRC32ComputeCallThenNotThrowAnyException()
        {
            var calculator = new CRC32EntityUnicityCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new System.DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Compute(instance);

            calculator.Compute(null)
                .Should().Be(uint.MinValue);
        }

        [Fact]
        public void UsingAnValidInstanceWhenCRC16ComputeCallThenNotThrowAnyException()
        {
            var calculator = new CRC16EntityUnicityCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new System.DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Compute(instance);

            calculator.Compute(null)
                .Should().Be(ushort.MinValue);
        }
    }
}
