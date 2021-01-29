using FluentAssertions;
using FluentHashCalculator.Tests.Fakes;
using System;
using System.Text;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class AbstractHashCalculatorTests
    {
        [Fact]
        public void UsingAnValidInstanceWhenCRC64ComputeCallThenNotThrowAnyException()
        {
            var calculator = new CRC64EntityAbstractHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Compute(instance);

            calculator.Compute(null)
                .Should().Be(ulong.MinValue);

            calculator = new CRC64EntityAbstractHashCalculator(ignoreErrors: false);

            Assert.Throws<NullReferenceException>(() => calculator.Compute(instance));

            instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test", 
                Another = new AnotherEntity()
            };

            calculator.Compute(instance);
        }

        [Fact]
        public void UsingAnValidInstanceWhenCRC32ComputeCallThenNotThrowAnyException()
        {
            var calculator = new CRC32EntityAbstractHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Compute(instance);

            calculator.Compute(null)
                .Should().Be(uint.MinValue);

            calculator = new CRC32EntityAbstractHashCalculator(ignoreErrors: false);

            Assert.Throws<NullReferenceException>(() => calculator.Compute(instance));

            instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test",
                Another = new AnotherEntity()
            };

            calculator.Compute(instance);
        }

        [Fact]
        public void UsingAnValidInstanceWhenCRC16ComputeCallThenNotThrowAnyException()
        {
            var calculator = new CRC16EntityAbstractHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Compute(instance);

            calculator.Compute(null)
                .Should().Be(ushort.MinValue);

            calculator = new CRC16EntityAbstractHashCalculator(ignoreErrors: false);

            Assert.Throws<NullReferenceException>(() => calculator.Compute(instance));

            instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test",
                Another = new AnotherEntity()
            };

            calculator.Compute(instance);
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA1ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA1EntityAbstractHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            var expected = Convert.ToBase64String(result);

            expected
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();

            calculator = new SHA1EntityAbstractHashCalculator(ignoreErrors: false);

            Assert.Throws<NullReferenceException>(() => calculator.Compute(instance));

            Assert.Throws<NullReferenceException>(() => calculator.Base64(instance));

            instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test",
                Another = new AnotherEntity()
            };

            calculator.Compute(instance);
            calculator.Base64(instance);
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA256ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA256WithUTF32EncodingEntityAbstractHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            calculator.Encoding
                .Should().Be(Encoding.UTF32);

            calculator.IgnoreErrors
                .Should().BeTrue();

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            var expected = Convert.ToBase64String(result);

            expected
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();

            calculator = new SHA256WithUTF32EncodingEntityAbstractHashCalculator(ignoreErrors: false);

            calculator.IgnoreErrors
                .Should().BeFalse();

            Assert.Throws<NullReferenceException>(() => calculator.Compute(instance));

            Assert.Throws<NullReferenceException>(() => calculator.Base64(instance));

            instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test",
                Another = new AnotherEntity()
            };

            calculator.Compute(instance);
            calculator.Base64(instance);
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA384ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA384EntityAbstractHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            var expected = Convert.ToBase64String(result);

            expected
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();

            calculator = new SHA384EntityAbstractHashCalculator(ignoreErrors: false);

            Assert.Throws<NullReferenceException>(() => calculator.Compute(instance));

            Assert.Throws<NullReferenceException>(() => calculator.Base64(instance));

            instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test",
                Another = new AnotherEntity()
            };

            calculator.Compute(instance);
            calculator.Base64(instance);
        }

        [Fact]
        public void UsingAnValidInstanceWhenSHA512ComputeCallThenNotThrowAnyException()
        {
            var calculator = new SHA512EntityAbstractHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test"
            };

            var result = calculator.Compute(instance);

            result
                .Should().NotBeNull().And.NotBeEmpty();

            var expected = Convert.ToBase64String(result);

            expected
                .Should().BeEquivalentTo(calculator.Base64(instance));

            calculator.Compute(null)
                .Should().BeEmpty();

            calculator.Base64(null)
                .Should().BeNullOrEmpty();

            calculator = new SHA512EntityAbstractHashCalculator(ignoreErrors: false);

            Assert.Throws<NullReferenceException>(() => calculator.Compute(instance));

            Assert.Throws<NullReferenceException>(() => calculator.Base64(instance));

            instance = new Entity
            {
                Id = 2,
                Birthday = new DateTime(2000, 11, 3),
                Name = "Test",
                Another = new AnotherEntity()
            };

            calculator.Compute(instance);
            calculator.Base64(instance);
        }
    }
}
