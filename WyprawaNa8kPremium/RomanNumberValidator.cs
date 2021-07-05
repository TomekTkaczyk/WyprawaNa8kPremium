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
                Regex.IsMatch(input, @"(^[IVXLCDM]*$)") &&
                !Regex.IsMatch(input, @"(I{4,}|C{4,}|X{4,}|M{5,})") &&
                !Regex.IsMatch(input, @"(V{2,}|L{2,}|D{2,})") &&
                !Regex.IsMatch(input, @"(V[XLCDM]|L[CDM]|DM)") &&
                !Regex.IsMatch(input, @"(I{2,}[VXLCDM]|X{2,}[LCDM]|C{2,}[DM])") &&
                !Regex.IsMatch(input, @"(I[LCDM])") &&
                !Regex.IsMatch(input, @"(X[DM])") &&
                !Regex.IsMatch(input, @"(I[VX][IVXLC])") &&
                !Regex.IsMatch(input, @"(X[LC][XLCDM])") &&
                !Regex.IsMatch(input, @"(C[DM][CDM])") &&
                !Regex.IsMatch(input, @"(VI{1,}[VX])") &&
                !Regex.IsMatch(input, @"(XI{2,}[VX])");
        }

        public bool Validate1(string input)
        {
            if(!Regex.IsMatch(input, @"^[IVXLCDM]*$"))
            {
                return false;
            }

            var rn = new RomanNumber(input);

            return String.Equals(input, rn.ToInt().ToRoman());
        }
    }
}
