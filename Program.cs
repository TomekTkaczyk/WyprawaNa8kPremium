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

        static int BinaryGap1(int number)
        {
            int tymczas = 0;
            int wynik = 0;
            string b = Convert.ToString(number, 2);
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '0')
                {
                    tymczas++;
                }
                else
                {
                    if (wynik <= tymczas)
                    {
                        wynik = tymczas;
                    }
                    tymczas = 0;
                }
            }
            return wynik;
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
    }
}
