using System;
using System.Text;
using System.Text.RegularExpressions;

namespace WyprawaNa8kPremium
{
    public class Substring
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

        public int LengthOfLongestSubstring2(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            if (!Regex.IsMatch(s, @"[ -~]"))
            {
                throw new ArgumentException("Bad argument");
            }

            if (s.Length == 1)
            {
                return 1;
            }

            var maxString = "";
            int head = 0;
            int tail = 0;

            while(head < s.Length)
            {
                if (s[tail..head].Contains(s[head]))
                {
                    if (head - tail > maxString.Length)
                    {
                        maxString = s[tail..head];
                    }
                    tail += s[tail..head].IndexOf(s[head]) + 1;
                }
                head++;
            }

            head--;

            if(!s[tail..head].Contains(s[head]))
            {
                head++;
                if(head - tail > maxString.Length)
                {
                    maxString = s[tail..head];
                }
            }

            return maxString.Length;
        }
    }
}
