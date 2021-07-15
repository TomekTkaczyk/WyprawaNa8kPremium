using System;
using System.Collections.Generic;
using System.Text;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class ThiefTests
    {
        [Theory]
        [InlineData(4, new int[] {1, 2, 3, 1})]
        [InlineData(12, new int[] { 2, 7, 9, 3, 1 })]
        [InlineData(17, new int[] { 2, 1, 9, 15, 1 })]
        public void Rob_resturn_expected_value(int expectedMaximumValue, int[] valueArray)
        {
            var thief = new Thief();

            Assert.Equal(expectedMaximumValue, thief.Rob(valueArray));
        }

        [Theory]
        [InlineData(4, new int[] { 1, 2, 3, 1 })]
        [InlineData(12, new int[] { 2, 7, 9, 3, 1 })]
        [InlineData(17, new int[] { 2, 1, 9, 15, 1 })]
        public void Rob1_resturn_expected_value(int expectedMaximumValue, int[] valueArray)
        {
            var thief = new Thief();

            Assert.Equal(expectedMaximumValue, thief.Rob1(valueArray));
        }
    }
}
