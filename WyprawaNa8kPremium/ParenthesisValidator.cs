using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8kPremium
{
    public class ParenthesesValidator
    {

        public bool IsValid(string s)
        {
            Dictionary<char, char> ParenthesesPairs = new Dictionary<char, char>()
            {
                { ')','(' },
                { '}','{' },
                { ']','[' },
            };
            var stack = new Stack<char>();

            foreach(var item in s)
            {
                if (ParenthesesPairs.ContainsValue(item))
                {
                    stack.Push(item);
                }
                else if(ParenthesesPairs.ContainsKey(item))
                {
                    try
                    {
                        if (!stack.Pop().Equals(ParenthesesPairs[item]))
                        {
                            return false;
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
