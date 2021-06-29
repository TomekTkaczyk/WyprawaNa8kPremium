using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WyprawaNa8kPremium
{
    public class RomanNumberValidator : IValidator
    {
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
        
        public bool Validate(string input)
        {
            return
                Regex.IsMatch(input, @"^[IVXLCDM]*$") &&
                !Regex.IsMatch(input, @"I{4,}|C{4,}|X{4,}|M{5,}") &&
                !Regex.IsMatch(input, @"V{2,}|L{2,}|D{2,}") &&
                !Regex.IsMatch(input, @"V[XLCDM]|L[CDM]|DM") &&
                !Regex.IsMatch(input, @"II[VXLCDM]|XX[LCDM]|CC[DM]") &&
                !Regex.IsMatch(input, @"I[LCDM]");
        }
    }
}
