using System;
using System.Linq;

namespace WyprawaNa8kPremium
{
    public class Pangram
    {
        public static bool IsPangram01(string sentence)
        {
            if(sentence.Length > 1000)
            {
                throw new ArgumentOutOfRangeException("sentence", "Sentence exceeds 1000 characters");
            }
            return sentence.ToLower().ToHashSet().Where(x => x > 96 && x < 123).Count() == 26;

        }
    }
}

