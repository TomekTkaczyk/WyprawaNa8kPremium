using System.Collections.Generic;
using System.Linq;
using System;

namespace WyprawaNa8kPremium
{
    public class NumbersList
    {
        // Brute force
        public bool IsSumExist01(List<int> numbers, int k)
        {
            numbers.Sort();
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] + numbers[j] == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // With LINQ preorder
        // Work only with positive numbers :(

        public bool IsSumExist02(List<int> numbers, int k)
        {

            var sortedNumbers = numbers.Where(x => x <= k ).OrderBy(x => x).ToList();

            for (var i = 0; i < numbers.Count - 1; i++)
            {
                for (var j = numbers.Count - 1; j > i; j--)
                {
                    if(numbers[i] + numbers[j] < k)
                    {
                        break;
                    }
                    else if (numbers[i] + numbers[j] == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
