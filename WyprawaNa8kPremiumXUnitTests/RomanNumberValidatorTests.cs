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
        [InlineData("XCX")]
        [InlineData("XD")]
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
        public void When_argument_is_valid_roman_number_then_validate1_should_by_return_true(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            Assert.True(validator.Validate1(romanNumber));
        }

        [Theory]
        [InlineData("MMMDCCCLXXXVIIIA")]
        [InlineData("MMMDCCCLXXXXVIII")]
        [InlineData("MMMDCCCLLXXXVIII")]
        [InlineData("XIIX")]
        [InlineData("IL")]
        [InlineData("XCX")]
        [InlineData("XD")]
        public void When_argument_is_not_valid_roman_number_then_validate1_should_by_return_false(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            Assert.False(validator.Validate1(romanNumber));
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

        [Theory]
        [InlineData("MMMDCCCLXXXVIII")]
        [InlineData("MMXI")]
        [InlineData("MCMLVI")]
        [InlineData("XXX")]
        [InlineData("XLIX")]
        [InlineData("IL")]
        [InlineData("XCX")]
        [InlineData("XD")]
        public void RomanNumberValidator_should_by_return_expected_value(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            var rn = new RomanNumber(romanNumber);
            var expected = (rn.Value == rn.ToInt().ToRoman());

            Assert.Equal(expected, validator.Validate(romanNumber));
        }
    }
}
