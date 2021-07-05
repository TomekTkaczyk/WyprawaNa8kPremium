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
        [InlineData("LC")]
        [InlineData("IC")]
        [InlineData("ID")]
        [InlineData("IM")]
        [InlineData("XCX")]
        [InlineData("XD")]
        [InlineData("IXI")]
        [InlineData("CDC")]
        [InlineData("CDM")]
        [InlineData("CMD")]
        [InlineData("VL")]
        [InlineData("IIX")]
        [InlineData("VIX")]
        [InlineData("XCL")]
        [InlineData("IXC")]
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
        [InlineData("XCIX")]
        [InlineData("CDXCVIII")]
        [InlineData("MCDXCVII")]
        [InlineData("DCCCXC")]
        [InlineData("CDXCIX")]
        [InlineData("XLV")]
        [InlineData("XIV")]
        [InlineData("CMXCIX")]
        [InlineData("MCCCXCVII")]
        public void When_argument_is_valid_roman_number_then_validate1_should_by_return_true(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            Assert.True(validator.Validate(romanNumber));
        }

        [Theory]
        [InlineData("MMMDCCCLXXXVIIIA")]
        [InlineData("MMMDCCCLXXXXVIII")]
        [InlineData("MMMDCCCLLXXXVIII")]
        [InlineData("XIIX")]
        [InlineData("IL")]
        [InlineData("LC")]
        [InlineData("IC")]
        [InlineData("ID")]
        [InlineData("IM")]
        [InlineData("XCX")]
        [InlineData("XD")]
        [InlineData("IXI")]
        [InlineData("CDC")]
        [InlineData("CDM")]
        [InlineData("CMD")]
        [InlineData("VL")]
        [InlineData("IIX")]
        [InlineData("VIX")]
        [InlineData("XCL")]
        [InlineData("IXC")]
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
        [InlineData("XCIX")]
        [InlineData("CDXCVIII")]
        [InlineData("MCDXCVII")]
        [InlineData("DCCCXC")]
        [InlineData("CDXCIX")]
        [InlineData("XLV")]
        [InlineData("CMXCIX")]
        public void When_argument_is_valid_roman_number_then_should_by_return_true(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            Assert.True(validator.Validate1(romanNumber));
        }

        [Theory]
        [InlineData("MMMDCCCLXXXVIII")]
        [InlineData("MMXI")]
        [InlineData("MCMLVI")]
        [InlineData("XXX")]
        [InlineData("XLIX")]
        [InlineData("XCIX")]
        [InlineData("CDXCVIII")]
        [InlineData("MCDXCVII")]
        [InlineData("DCCCXC")]
        [InlineData("CDXCIX")]
        [InlineData("XLV")]
        [InlineData("CMXCIX")]
        public void RomanNumberValidator_should_by_return_expected_value(string romanNumber)
        {
            var validator = new RomanNumberValidator();

            var rn = new RomanNumber(romanNumber);
            var expected = (rn.Value == rn.ToInt().ToRoman());

            Assert.Equal(expected, validator.Validate(romanNumber));
        }
    }
}
