using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class RomanNumberTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(95, "XCV")]
        [InlineData(900, "CM")]
        [InlineData(914, "CMXIV")]
        [InlineData(1995, "MCMXCV")]
        [InlineData(2000, "MM")]
        [InlineData(1956, "MCMLVI")]
        [InlineData(2011, "MMXI")]
        [InlineData(3888, "MMMDCCCLXXXVIII")]
        [InlineData(49, "XLIX")]
        public void ToInt_should_by_return_expected_value(int expected, string romanNumber)
        {
            var rn = new RomanNumber(romanNumber);

            Assert.Equal(expected, rn.ToInt());
        }
    }
}
