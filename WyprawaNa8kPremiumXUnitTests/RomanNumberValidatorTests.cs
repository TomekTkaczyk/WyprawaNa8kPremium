using System;
using System.Collections.Generic;
using System.Text;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class RomanNumberValidatorTests
    {

        [Theory]
        [InlineData("MMMDCCCLXXXVIIIA")]
        [InlineData("MMMDCCCLXXXXVIII")]
        [InlineData("MMMDCCCLLXXXVIII")]
        [InlineData("XIIX")]
        [InlineData("IL")]
        public void When_argument_is_not_valid_roman_number_then_should_by_return_false(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            Assert.False(validator.Validate(romanNumber));
        }

        [Theory]
        [InlineData("MMMDCCCLXXXVIII")]
        [InlineData("MMXI")]
        [InlineData("MCMLVI")]
        [InlineData("XXX")]
        [InlineData("XLIX")]

        public void When_argument_is_valid_roman_number_then_should_by_return_true(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            Assert.True(validator.Validate(romanNumber));
        }
    }
}
