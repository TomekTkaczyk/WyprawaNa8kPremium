using System;
using System.Linq;

namespace WyprawaNa8kPremium
{
    public class Pangram
    {
        public static bool IsPangram01(string sentence)
        {
            int maxLengthSentence = 1000;

            return sentence.Length > maxLengthSentence ?
                throw new ArgumentOutOfRangeException("sentence", "Sentence exceeds 1000 characters") :
                sentence.ToLower().ToHashSet().Where(x => x >= 'a' && x <= 'z').Count() == ('z'-'a' + 1);
        }
    }
}

