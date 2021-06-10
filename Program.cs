using System;
using System.Collections.Generic;
using System.Linq;

namespace WyprawaNa8kPremium
{
    class Program
    {
        static void Main(string[] args)
        {
            Task02_JewelsAndStones();
            //Task01_BinaryGap();
        }

        private static void Task02_JewelsAndStones()
        {
            Console.WriteLine(CountJewelsInStones01("aA", "BBBabAAbbb"));
            Console.WriteLine(CountJewelsInStones01("Z", "ZZ"));
            Console.WriteLine(CountJewelsInStones01("z", "ZZ"));

            Console.WriteLine(CountJewelsInStones02("aA", "BBBabAAbbb"));
            Console.WriteLine(CountJewelsInStones02("Z", "ZZ"));
            Console.WriteLine(CountJewelsInStones02("z", "ZZ"));

            // brute force
            static int CountJewelsInStones01(string jewels, string stones) 
            {
                int count = 0;
                for(int i = 0; i < stones.Length; i++)
                {
                    if (jewels.Contains(stones[i]))
                    {
                        count++;
                    }
                }
            
                return count;
            }

            // LINQ
            static int CountJewelsInStones02(string jewels, string stones)
            {
                return stones.Where(x => jewels.Contains(x)).Count();
            }


        }

        static void Task01_BinaryGap()
        {
            Console.WriteLine(BinaryGap.BinaryGap3b(18592));
            Console.WriteLine(BinaryGap.BinaryGap3b(1054));
            Console.WriteLine(BinaryGap.BinaryGap3b(100));
            Console.WriteLine(BinaryGap.BinaryGap3b(64));
        }
    }
}
