using System;
using System.Collections.Generic;
using System.Text;

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

                if(digits.Length > 0)
                {
                    var temp = AddLetters(digits[1..]);
                    for (var j = 0; j < letters[digits[0]].Length; j++)
                    {
                        var letter = letters[digits[0]][j];
                        if (temp.Count == 0)
                        {
                            result.Add(letters[digits[0]][j].ToString());
                        }
                        else
                        {
                            for (var i = 0; i < temp.Count; i++)
                            {
                                result.Add(letters[digits[0]][j] + temp[i]);
                            }
                        }
                    }
                }

                return result; 
            }

            return AddLetters(digits).ToArray();
        }
    }
}
