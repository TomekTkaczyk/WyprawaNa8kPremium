using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WyprawaNa8kPremium
{
    public class RomanNumberValidator : IValidator
    {       
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
