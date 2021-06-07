using System;

namespace WyprawaNa8kPremium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryGap(8768));
            Console.WriteLine(BinaryGap(1054));
            Console.WriteLine(BinaryGap(100));
            Console.WriteLine(BinaryGap(64));
        }

        static int BinaryGap(int number)
        {
            var sum = 0;
            var binaryGap = 0;
            var binary = Convert.ToString(number,2);
            for(int i = 0; i < binary.Length; i++)
            {
                if (binary[i].Equals('0'))
                {
                    sum = i == binary.Length - 1 ? 0 : sum + 1;
                }
                else
                {
                    binaryGap = Math.Max(binaryGap,sum);
                    sum = 0;
                }
            }
            return binaryGap;
        }
    }
}
