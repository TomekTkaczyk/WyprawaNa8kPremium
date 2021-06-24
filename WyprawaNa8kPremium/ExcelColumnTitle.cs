using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WyprawaNa8kPremium
{
    public class ExcelColumnTitle
    {
        public int TitleToNumber01(string columnTitle)
        {
            if(!Regex.IsMatch(columnTitle, @"(^[A-Z]{1,2}$)|(^[A-X][A-F][A-D]$)"))
            {
                throw new ArgumentException();
            }

            int result = 0;
            int multipler = 1;
            for(var i = columnTitle.Length-1; i > -1; i--)
            {
                result += (columnTitle[i] - 64) * multipler;
                multipler *= 26;
            }

            return result;
        }
    }
}
