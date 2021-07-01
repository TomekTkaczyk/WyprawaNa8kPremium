using System;
using System.Collections.Generic;
using System.Text;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class IntExtensionTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XII", 12)]
        [InlineData("XIII", 13)]
        [InlineData("XIV", 14)]
        [InlineData("XV", 15)]
        [InlineData("XVI", 16)]
        [InlineData("XVII", 17)]
        [InlineData("XVIII", 18)]
        [InlineData("XIX", 19)]
        [InlineData("XX", 20)]
        [InlineData("XXI", 21)]
        [InlineData("XXVII", 27)]
        [InlineData("XXIX", 29)]
        [InlineData("XXXIX", 39)]
        [InlineData("XLIX", 49)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("CM", 900)]
        [InlineData("CMXIV", 914)]
        [InlineData("MCMXCV", 1995)]
        [InlineData("MM", 2000)]
        [InlineData("MCMLVI", 1956)]
        [InlineData("MMXI", 2011)]
        [InlineData("MMMDCCCLXXXVIII", 3888)]
        [InlineData("MMMMCMXCIX", 4999)]
        public void IntExtension_ToRoman_should_by_return_expected_value(string expected, int value)
        {
            Assert.Equal(expected, value.ToRoman());
        }
    }
}
