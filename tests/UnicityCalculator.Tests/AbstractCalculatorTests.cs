using UnicityCalculator.Tests.Fakes;
using Xunit;

namespace UnicityCalculator.Tests
{
    public class AbstractCalculatorTests
    {
        private static readonly AbstractCalculator<Entity> CALCULATOR
            = new EntityUnicityCalculator();

        [Fact]
        public void Test()
        {
            var instance = new Entity
            {
                Id = 2,
                Birthday = new System.DateTime(2000, 11, 3),
                Name = "Test"
            };

            CALCULATOR.Compute(instance);
        }
    }
}
