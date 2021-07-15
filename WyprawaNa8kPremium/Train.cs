using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WyprawaNa8kPremium
{
    public class Train
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 0)
            {
                return 0;
            }

            if (!Regex.IsMatch(s, @"[ -~]"))
            {
                throw new ArgumentException("Bad argument");
            }

            var max = 0;
            for(var i = 0; i < s.Length-1; i++)
            {
                var tmp = new StringBuilder();
                tmp.Append(s[i]);
                var j = i + 1;
                while( j < s.Length && !tmp.ToString().Contains(s[j]))
                {
                    tmp.Append( s[j++] );
                }
                max = Math.Max(max, tmp.Length);
            }

            return max;
        }
    }
}
