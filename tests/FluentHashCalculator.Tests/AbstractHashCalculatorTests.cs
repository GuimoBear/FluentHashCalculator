using FluentAssertions;
using FluentHashCalculator.Tests.Fakes;
using System;
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
                Birthday = new DateTime(2000, 11, 3),
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
                Birthday = new DateTime(2000, 11, 3),
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
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Compute(instance);

            calculator.Compute(null)
                .Should().Be(ushort.MinValue);
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA1ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA1EntityUnicityCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            Convert.ToBase64String(result)
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA256ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA256EntityUnicityCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            Convert.ToBase64String(result)
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA384ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA384EntityUnicityCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            Convert.ToBase64String(result)
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA512ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA512EntityUnicityCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            Convert.ToBase64String(result)
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();
        }
    }
}
