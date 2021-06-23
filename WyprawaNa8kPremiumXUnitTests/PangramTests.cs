using System;
using System.Text;
using WyprawaNa8kPremium;
using Xunit;

namespace WyprawaNa8kPremiumTests
{
    public class PangramTests
    {
        [Theory]
        [InlineData(true, "The quick brown fox jumps over the lazy dog")]
        [InlineData(false, "I am programmer")]
        [InlineData(true, "The quick brown fox jumps over the lazy dog. 123 ółśćżźć")]
        [InlineData(false, "The quick brown fox jumps over the l_zy dog. 123 ółśćżźć")]
        public void Pangram01_schould_by_return_expected_value(bool expected, string sentence)
        {
            var pangram = new Pangram();
            bool result = pangram.IsPangram01(sentence);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_sentence_is_longer_than_1000_characters_shuld_by_throw_exception()
        {
            var pangram = new Pangram();
            var sentence = new StringBuilder();
            for(var i = 0; i < 100; i++)
            {
                sentence.Append(" next word");
            }
            sentence.Append(" ");

            Assert.True(sentence.Length > 1000);
            Assert.Throws< ArgumentOutOfRangeException>(() => pangram.IsPangram01(sentence.ToString()));
        }
    }
}
