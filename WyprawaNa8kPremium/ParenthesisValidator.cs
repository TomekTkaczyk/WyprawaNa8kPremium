﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8kPremium
{
    public class ParenthesisValidator
    {

        public bool IsValid(string s)
        {
            Dictionary<char, char> ParenthesisPairs = new Dictionary<char, char>()
            {
                { ')','(' },
                { '}','{' },
                { ']','[' },
            };
            var stack = new Stack<char>();

            foreach(var item in s)
            {
                if (ParenthesisPairs.ContainsValue(item))
                {
                    stack.Push(item);
                }
                else if(ParenthesisPairs.ContainsKey(item))
                {
                    if (stack.Count == 0 || !stack.Pop().Equals(ParenthesisPairs[item]))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
