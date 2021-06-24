using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class ExcelColumnTitleTest
    {
        [Theory]
        [InlineData("_")]
        [InlineData("1")]
        [InlineData("A1")]
        [InlineData("ZZZ")]
        [InlineData("XFE")]
        public void When_argument_is_not_a_Excel_column_title_should_by_throw_bad_argument_exception(string title)
        {
            var sheet = new ExcelSheet();

            Assert.Throws<ArgumentException>(() => sheet.TitleToNumber01(title));
        }

        [Theory]
        [InlineData("A", 1)]
        [InlineData("Z", 26)]
        [InlineData("AA", 27)]
        [InlineData("ZZ", 702)]
        [InlineData("AAA", 703)]
        [InlineData("XFD", 16384)]
        public void When_argument_is_a_Excel_column_title_should_by_return_column_number(string title, int expectedValue)
        {
            var sheet = new ExcelSheet();

            Assert.Equal(expectedValue, sheet.TitleToNumber01(title));
        }
    }
}
