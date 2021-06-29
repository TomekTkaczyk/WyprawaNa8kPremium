using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WyprawaNa8kPremium
{
    public class RomanNumber
    {
        private readonly string _romanNumber;
        private readonly Dictionary<char, int> dictNumbers = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public RomanNumber(string romanNumber)
        {
            _romanNumber = romanNumber;
        }

        public string Value 
        { 
            get 
            { 
                return _romanNumber; 
            } 
        }

        public int ToInt()
        {
            int result = 0;

            for (int i = 0; i < _romanNumber.Length; i++)
            {
                if ((i == _romanNumber.Length - 1) || (dictNumbers[_romanNumber[i]] >= dictNumbers[_romanNumber[i + 1]]))
                {
                    result += dictNumbers[_romanNumber[i]];
                }
                else
                {
                    result += dictNumbers[_romanNumber[i + 1]] - dictNumbers[_romanNumber[i]];
                    i++;
                }
            }

            return result;
        }
    }
}
