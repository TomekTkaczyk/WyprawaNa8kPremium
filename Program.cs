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
            Console.WriteLine(JewelsStones.CountJewelsInStones01("aA", "BBBabAAbbb"));
            Console.WriteLine(JewelsStones.CountJewelsInStones01("Z", "ZZ"));
            Console.WriteLine(JewelsStones.CountJewelsInStones01("z", "ZZ"));

            Console.WriteLine(JewelsStones.CountJewelsInStones02("aA", "BBBabAAbbb"));
            Console.WriteLine(JewelsStones.CountJewelsInStones02("Z", "ZZ"));
            Console.WriteLine(JewelsStones.CountJewelsInStones02("z", "ZZ"));

            Console.WriteLine(JewelsStones.CountJewelsInStones03("aA", "BBBabAAbbb"));
            Console.WriteLine(JewelsStones.CountJewelsInStones03("Z", "ZZ"));
            Console.WriteLine(JewelsStones.CountJewelsInStones03("z", "ZZ"));

            Console.WriteLine(JewelsStones.CountJewelsInStones03("aA", "BBBabAAbbb"));
            Console.WriteLine(JewelsStones.CountJewelsInStones03("Z", "ZZ"));
            Console.WriteLine(JewelsStones.CountJewelsInStones03("z", "ZZ"));
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
