using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class AbstractCalculatorTests
    {

        [Fact]
        public void Test()
        {
            var calculator = new EntityFluentHashCalculator();

            var instance = new Entity
            {
                Id = 2,
                Birthday = new System.DateTime(2000, 11, 3),
                Name = "Test"
            };

            var crc64 = calculator.Compute(instance);
        }
    }
}
