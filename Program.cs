using System;
using System.Text.RegularExpressions;

namespace WyprawaNa8kPremium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryGap3(1054));
            Console.WriteLine(BinaryGap3(100));
            Console.WriteLine(BinaryGap3(64));
        }

        static int BinaryGap1(int number)
        {
            var sum = 0;
            var binaryGap = 0;
            var binary = Convert.ToString(number,2);
            for(int i = 0; i < binary.Length; i++)
            {
                if (binary[i].Equals('0'))
                {
                    sum++;
                }
                else
                {
                    binaryGap = Math.Max(binaryGap,sum);
                    sum = 0;
                }
            }
            return binaryGap;
        }

        static int BinaryGap2(int number)
        {
            var sum = 0;
            var binaryGap = 0;
            var binary = Convert.ToString(number, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i].Equals('0'))
                {
                    sum++;
                }
                else
                {
                    if(sum > binaryGap)
                    {
                        binaryGap = sum;
                    }
                    sum = 0;
                }
            }
            return binaryGap;
        }

        static int BinaryGap3(int number)
        {
            var binaryGap = 0;
            var binary = Convert.ToString(number, 2);
            var result = Regex.Matches(binary,"0+1");

            for(var i = 0; i < result.Count; i++)
            {
                if (result[i].Length > binaryGap)
                {
                    binaryGap = result[i].Length;
                }
            }

            return binaryGap > 1 ? binaryGap - 1 : 0;
        }
    }
}
