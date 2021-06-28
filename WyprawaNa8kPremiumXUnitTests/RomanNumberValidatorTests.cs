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
        [InlineData("MMMDCCCALXXXVIII")]
        public void When_argument_is_not_valid_roman_number_then_should_by_throw_exception(string romanNumber)
        {
            Assert.Throws<ArgumentException>(() => new RomanNumber(romanNumber));
        }
    }
}
