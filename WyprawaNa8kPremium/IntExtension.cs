using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8kPremium
{
    public static class IntExtension
    {
        public static string ToRoman(this int currentValue)
        {
            int value = currentValue;

            if(value > 4999)
            {
                return "";
            }

            var result = new StringBuilder();
            while(value > 999)
            {
                result.Append("M");
                value -= 1000;
            }
            if(value > 899)
            {
                result.Append("CM");
                value -= 900;
            }
            if(value > 499)
            {
                result.Append("D");
                value -= 500;
            }
            if(value > 399)
            {
                result.Append("CD");
                value -= 400;
            }
            while(value > 99)
            {
                result.Append("C");
                value -= 100;
            }
            if(value > 89)
            {
                result.Append("XC");
                value -= 90;
            }
            if(value > 49)
            {
                result.Append("L");
                value -= 50;
            }
            if(value > 39)
            {
                result.Append("XL");
                value -= 40;
            }
            while(value > 9)
            {
                result.Append("X");
                value -= 10;
            }
            if(value > 8)
            {
                result.Append("IX");
                value -= 9;
            }
            while(value > 5)
            {
                result.Append("V");
                value -= 5;
            }
            if (value > 4)
            {
                result.Append("V");
                value -= 5;
            }
            if (value > 3)
            {
                result.Append("IV");
                value -= 4;
            }
            while(value > 0)
            {
                result.Append("I");
                value -= 1;
            }

            return result.ToString();
        }
    }
}
