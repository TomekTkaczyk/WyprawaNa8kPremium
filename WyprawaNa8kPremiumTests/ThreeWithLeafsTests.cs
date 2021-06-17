using System;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumTests
{
    public class ThreeWithLeafsTests
    {
        [Theory]
        [InlineData(19, 6, 7, 8, 2, 7, 1, 3, 9, null, 1, 4, null, null, null, 5)]
        [InlineData(15, 1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8)]
        [InlineData(49, 1, 2, 3, 4, null, 6, 7, 8, 9, null, null, 12, 13, 14, null, 16, null, null, 19, null, null, null, 23, null, null, 26)]
        public void LovestLevelLeafsSumValue_shuld_by_return_expected_value(int expected, params int?[] arr)
        {
            var tree = new TreeWithLeafs(arr);
            var result = tree.LovestLevelLeafsSumValue();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_value_of_node_is_large_than_100_shuld_by_throw_exception()
        {

            int?[] arr = { 101 };
            var tree = new TreeWithLeafs(arr);

            Assert.Throws<ArgumentOutOfRangeException>(() => tree.LovestLevelLeafsSumValue());
        }

        [Fact]
        public void When_size_of_tree_is_large_than_10000_shuld_by_throw_exception()
        {

            int?[] arr = new int?[10001];

            Assert.Throws<ArgumentOutOfRangeException>(() => new TreeWithLeafs(arr));
        }
    }
}
