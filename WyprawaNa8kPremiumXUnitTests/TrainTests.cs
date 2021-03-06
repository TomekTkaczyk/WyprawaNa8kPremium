using System;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class TrainTests
    {
        [Theory]
        [InlineData(3, "abcabcbb")]
        [InlineData(1, "bbbbb")]
        [InlineData(3, "pwwkew")]
        [InlineData(7, "pwwkewsl gs")]
        [InlineData(8, "pwwkewsl gh")]
        [InlineData(0, "")]
        public void LengthOfLongestSubstring_should_by_return_expected_value(int expected, string s)
        {
            var train = new Substring();

            Assert.Equal(expected, train.LengthOfLongestSubstring(s));
        }

        [Fact]
        public void When_argument_is_out_of_valid_data_LengthOfLongestSubstring_should_by_return_ArgumentEception()
        {
            var train = new Substring();

            Assert.Throws<ArgumentException>(() => train.LengthOfLongestSubstring("ą"));
        }

        [Fact]
        public void When_argument_is_all_alphabet_LengthOfLongestSubstring_should_by_return_96()
        {
            var train = new Substring();
            var s = string.Empty;
            for(var i = 32; i < 128; i++)
            {
                s += ((char)i).ToString();
            }

            Assert.Equal(96, train.LengthOfLongestSubstring(s.ToString()));
        }


        [Theory]
        [InlineData(3, "abcabcbb")]
        [InlineData(1, "bbbbb")]
        [InlineData(3, "pwwkew")]
        [InlineData(7, "pwwkewsl gs")]
        [InlineData(8, "pwwkewsl gh")]
        [InlineData(0, "")]                 
        public void LengthOfLongestSubstring2_should_by_return_expected_value(int expected, string s)
        {
            var train = new Substring();

            Assert.Equal(expected, train.LengthOfLongestSubstring2(s));
        }

        [Fact]
        public void When_argument_is_out_of_valid_data_LengthOfLongestSubstring2_should_by_return_ArgumentEception()
        {
            var train = new Substring();

            Assert.Throws<ArgumentException>(() => train.LengthOfLongestSubstring2("ą"));
        }

        [Fact]
        public void When_argument_is_all_alphabet_LengthOfLongestSubstring2_should_by_return_96()
        {
            var train = new Substring();
            var s = string.Empty;
            for (var i = 32; i < 128; i++)
            {
                s += ((char)i).ToString();
            }

            Assert.Equal(96, train.LengthOfLongestSubstring2(s.ToString()));
        }
    }
}
