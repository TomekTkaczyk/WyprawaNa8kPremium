using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class Nokia3310Tests
    {
        [Fact]
        public void LetterCombinations_should_by_return_array()
        {
            var nokia = new Nokia3310();

            Assert.IsType<string[]>(nokia.LetterCombinations(""));
        }

        [Theory]
        [InlineData("232",
            "ada", "adb", "adc", "aea", "aeb", "aec", "afa", "afb", "afc",
            "bda", "bdb", "bdc", "bea", "beb", "bec", "bfa", "bfb", "bfc",
            "cda", "cdb", "cdc", "cea", "ceb", "cec", "cfa", "cfb", "cfc"
            )]
        [InlineData("23", "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf")]
        [InlineData("24", "ag", "ah", "ai", "bg", "bh", "bi", "cg", "ch", "ci")]
        [InlineData("27", "ap", "aq", "ar", "as", "bp", "bq", "br", "bs", "cp", "cq", "cr", "cs")]
        public void LetterCombinations_should_by_return_expected_array(string digits, params string[] expected)
        {
            var nokia = new Nokia3310();
            var result = nokia.LetterCombinations(digits);

            Assert.Equal(expected.Length, result.Length);
            for(var i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i].Equals( result[i] ));
            }
        }
    }
}
