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

        // Brute force with sort numbers
        public bool IsSumExist02(List<int> numbers, int k)
        {
            numbers.Sort();
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] > k)
                {
                    return false;
                }
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    if(numbers[i] + numbers[j] > k)
                    {
                        break;
                    }
                    if (numbers[i] + numbers[j] == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // With preorder and SetHashSet
        public bool IsSumExist03(List<int> numbers, int k)
        {
            numbers.Sort();
            if (k % 2 == 0)
            {
                var i = numbers.IndexOf(k / 2);
                if((i > -1) && (numbers[i] == numbers[i+1]))
                {
                    return true;
                }
            }
            var hashSetNumbers = numbers.ToHashSet().ToList();
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers.Contains(k - hashSetNumbers[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
