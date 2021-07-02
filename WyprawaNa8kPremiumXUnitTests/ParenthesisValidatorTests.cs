using System;
using System.Collections.Generic;
using System.Text;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class ParenthesesValidatorTests
    {
        [Theory]
        [InlineData("()")]
        [InlineData("({}[]{{[]}})")]
        [InlineData("a=(b+c)*(d+e/(f+g))")]

        public void When_parentheses_pairs_have_valid_order_then_return_true(string s)
        {
            var pv = new ParenthesesValidator();

            Assert.True(pv.IsValid(s));
        }

        [Theory]
        [InlineData("([{})]")]
        [InlineData("a=(b+c)*{d+e/(f+g)]")]
        [InlineData("a=(b+c)*(d+e/[f+g))")]
        [InlineData("a=(b+c)*(d+e/[f+g)]")]
        public void When_parentheses_pairs_have_invalid_order_then_return_false(string s)
        {
            var pv = new ParenthesesValidator();

            Assert.False(pv.IsValid(s));
        }

        [Theory]
        [InlineData("({])")]
        [InlineData(")")]
        [InlineData("a=(b+c)*d+e/(f+g))")]

        public void When_parentheses_not_have_pair_then_return_false(string s)
        {
            var pv = new ParenthesesValidator();

            Assert.False(pv.IsValid(s));
        }
    }
}
