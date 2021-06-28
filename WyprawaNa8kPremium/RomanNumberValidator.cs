using System;
using System.Collections.Generic;
using System.Text;

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
        
        public bool Validate(string romanNumber)
        {
            throw new NotImplementedException();
        }
    }
}
