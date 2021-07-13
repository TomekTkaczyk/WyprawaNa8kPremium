using System.Collections.Generic;
using System.Linq;

namespace WyprawaNa8kPremium
{
    public class Nokia3310
    {
        public string[] LetterCombinations(string digits)
        {
            string result = string.Empty;

            var letters = new Dictionary<char, string>()
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            List<string> AddLetters(string digits)
            {
                var result = new List<string>();

                if(digits.Length == 1)
                {
                    foreach(var letter in letters[digits[0]])
                    {
                        result.Add(letter.ToString());
                    }
                }

                if(digits.Length > 1)
                {
                    var temp = AddLetters(digits[1..]);
                    foreach(var letter in letters[digits[0]])
                    {
                        foreach(var item in temp)
                        {
                            result.Add(letter + item);
                        }
                    }
                }

                return result; 
            }

            return AddLetters(digits).ToArray();
        }
    }
}
