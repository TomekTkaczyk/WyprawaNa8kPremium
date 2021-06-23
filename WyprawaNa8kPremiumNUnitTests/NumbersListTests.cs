using NUnit.Framework;
using System.Collections.Generic;
using WyprawaNa8kPremium;

namespace TestProject1
{
    public class NumbersListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(17, new int[] { 10, 15, 3, 7 })]
        [TestCase(18, new int[] { 10, 15, 3, 7 })]
        public void When_arraynumbers_contains_two_numbers_whouse_sum_is_k_NumbersIsSumExist01_should_be_return_true(int sum, int[] numbers)
        {
            var numbersList = new NumbersList();
            Assert.IsTrue(numbersList.IsSumExist01(new List<int>(numbers), sum));
        }

        [Test]
        [TestCase(17, new int[] { 10, 15, 3, 7 }, ExpectedResult = true)]
        [TestCase(18, new int[] { 10, 15, 3, 7 }, ExpectedResult = true)]
        [TestCase(19, new int[] { 10, 15, 3, 7 }, ExpectedResult = false)]
        public bool When_arraynumbers_contains_two_numbers_whouse_sum_is_k_NumbersIsSumExist03_should_be_return_true_otherwise_false(int sum, int[] numbers)
        {
            var numbersList = new NumbersList();
            return numbersList.IsSumExist01(new List<int>(numbers), sum);
        }
    }
}