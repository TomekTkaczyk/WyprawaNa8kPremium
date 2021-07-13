using System.Collections.Generic;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumXUnitTests
{
    public class NumbersListTests
    {
        [Theory]
        [InlineData(true, 17, new int[] { 10, 15, 3, 7 })]
        [InlineData(true, 18, new int[] { 10, 15, 3, 7 })]
        [InlineData(false, 19, new int[] { 10, 15, 3, 7 })]
        [InlineData(true, -2, new int[] { 10, -15, 13, 7 })]
        [InlineData(false, -3, new int[] { 10, -15, 13, 7 })]
        [InlineData(true, 0, new int[] { 10, -2, -2, 2, 6, 8 })]
        [InlineData(false, 1, new int[] { 10, -2, -2, 2, 6, 8 })]
        public void When_arraynumbers_contains_two_numbers_whouse_sum_is_k_NumbersIsSumExist01_should_be_return_true_otherwise_false(bool expectedResult, int k, int[] numbers)
        {
            var numbersList = new NumbersList();
            var result = numbersList.IsSumExist01(new List<int>(numbers), k);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(true, 17, new int[] { 10, 15, 3, 7 })]
        [InlineData(true, 18, new int[] { 10, 15, 3, 7 })]
        [InlineData(false, 19, new int[] { 10, 15, 3, 7 })]
        [InlineData(true, -2, new int[] { 10, -15, 13, 7 })]
        [InlineData(false, -3, new int[] { 10, -15, 13, 7 })]
        [InlineData(true, 0, new int[] { 10, -2, -2, 2, 6, 8 })]
        [InlineData(false, 1, new int[] { 10, -2, -2, 2, 6, 8 })]
        public void When_arraynumbers_contains_two_numbers_whouse_sum_is_k_NumbersIsSumExist02_should_be_return_true_otherwise_false(bool expectedResult, int k, int[] numbers)
        {
            var numbersList = new NumbersList();
            var result = numbersList.IsSumExist02(new List<int>(numbers), k);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData(true, 17, new int[] { 10, 15, 3, 7 })]
        [InlineData(true, 18, new int[] { 10, 15, 3, 7 })]
        [InlineData(false, 19, new int[] { 10, 15, 3, 7 })]
        [InlineData(true, -2, new int[] { 10, -15, 13, 7 })]
        [InlineData(false, -3, new int[] { 10, -15, 13, 7 })]
        [InlineData(true, 0, new int[] { 10, -2, -2, 2, 6, 8 })]
        [InlineData(false, 1, new int[] { 10, -2, -2, 2, 6, 8 })]
        public void When_arraynumbers_contains_two_numbers_whouse_sum_is_k_NumbersIsSumExist03_should_be_return_true_otherwise_false(bool expectedResult, int k, int[] numbers)
        {
            var numbersList = new NumbersList();
            var result = numbersList.IsSumExist03(new List<int>(numbers), k);

            Assert.Equal(expectedResult, result);
        }
    }
}
