using System;

namespace WyprawaNa8kPremium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryGap(1054));
            Console.WriteLine(BinaryGap(100));
            Console.WriteLine(BinaryGap(64));
        }

        static int BinaryGap(int number)
        {
            int sum = 0;
            int binaryGap = 0;
            var binary = Convert.ToString(number,2);
            for(int i = 0; i < binary.Length; i++)
            {
                if (binary[i].Equals('0'))
                {
                    if(i == binary.Length - 1)
                    {
                        sum = 0;
                    }
                    else
                    {
                        sum++;
                    }
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
