using System;
using System.Collections.Generic;
using System.Text;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumTests
{
    public class NumbersListTests
    {
        [Theory]
        [InlineData(17, 10, 15, 3, 7)]
        [InlineData(18, 10, 15, 3, 7)]
        public void IsSumExist01_should_by_return_true(int sum, params int[] numbers)
        {
            var numbersList = new NumbersList();

            Assert.True(numbersList.IsSumExist01(new List<int>(numbers), sum));
        }

        [Theory]
        [InlineData(19, 10, 15, 3, 7)]
        [InlineData(7, 10, 15, 3, 7)]
        public void IsSumExist01_should_by_return_false(int sum, params int[] numbers)
        {
            sum = -20;
            var numbersList = new NumbersList();

            Assert.False(numbersList.IsSumExist01(new List<int>(numbers), sum));
        }

        [Theory]
        [InlineData(17, 10, 15, 3, 7)]
        [InlineData(18, 10, 15, 3, 7)]
        public void IsSumExist02_should_by_return_true(int sum, params int[] numbers)
        {
            var numbersList = new NumbersList();

            Assert.True(numbersList.IsSumExist02(new List<int>(numbers), sum));
        }

        [Theory]
        [InlineData(19, 10, 15, 3, 7)]
        [InlineData(7, 10, 15, 3, 7)]

        public void IsSumExist02_should_by_return_false(int sum, params int[] numbers)
        {
            var numbersList = new NumbersList();

            Assert.False(numbersList.IsSumExist02(new List<int>(numbers), sum));
        }

        [Theory]
        [InlineData(17, 10, 15, 3, 7)]
        [InlineData(18, 10, 15, 3, 7)]
        public void IsSumExist03_should_by_return_true(int sum, params int[] numbers)
        {
            var numbersList = new NumbersList();

            Assert.True(numbersList.IsSumExist03(new List<int>(numbers), sum));
        }

        [Theory]
        [InlineData(19, 10, 15, 3, 7)]
        [InlineData(7, 10, 15, 3, 7)]

        public void IsSumExist03_should_by_return_false(int sum, params int[] numbers)
        {
            var numbersList = new NumbersList();

            Assert.False(numbersList.IsSumExist03(new List<int>(numbers), sum));
        }
    }
}
