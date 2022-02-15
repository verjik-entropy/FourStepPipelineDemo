using Xunit;

namespace FourStepPipelineDemo.Web.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator target;

        public CalculatorTests()
        {
            target = new Calculator();
        }

        [Fact]
        public void AddTwoPositivesTest()
        {
            Assert.Equal(13, target.Add(7, 6));
        }

        [Fact]
        public void AddTwoMaxPositivesTest()
        {
            Assert.Equal(4294967294, target.Add(int.MaxValue, int.MaxValue));
        }

        [Fact]
        public void AddTwoNegativesNegativeResult()
        {
            Assert.Equal(-31, target.Add(-13, -18));
        }

        [Fact]
        public void AddOnePositiveOneNegativesPositiveResult()
        {
            Assert.Equal(8, target.Add(-19, 27));
        }
    }
}
