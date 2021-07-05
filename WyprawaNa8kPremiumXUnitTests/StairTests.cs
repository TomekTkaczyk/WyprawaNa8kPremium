using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class StairTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 4)]
        [InlineData(8, 5)]
        [InlineData(13, 6)]
        public void ClimbStairs01_return_expected_various_ways(int expectedWays, int stepsCount)
        {
            var stairs = new Stairs();

            Assert.Equal(expectedWays, stairs.ClimbStairs01(stepsCount));
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 4)]
        [InlineData(8, 5)]
        [InlineData(13, 6)]
        public void ClimbStairs02_return_expected_various_ways(int expectedWays, int stepsCount)
        {
            var stairs = new Stairs();

            Assert.Equal(expectedWays, stairs.ClimbStairs02(stepsCount));
        }
    }
}
