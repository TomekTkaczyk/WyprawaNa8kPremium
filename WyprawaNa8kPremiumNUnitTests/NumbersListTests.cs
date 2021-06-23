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
        public void Test1(int sum, int[] numbers)
        {
            var numbersList = new NumbersList();
            Assert.IsTrue(numbersList.IsSumExist01(new List<int>(numbers), sum));
        }

        [Test]
        [TestCase(17, new int[] { 10, 15, 3, 7 }, ExpectedResult = true)]
        [TestCase(18, new int[] { 10, 15, 3, 7 }, ExpectedResult = true)]
        public bool Test2(int sum, int[] numbers)
        {
            var numbersList = new NumbersList();
            return numbersList.IsSumExist01(new List<int>(numbers), sum);
        }
    }
}