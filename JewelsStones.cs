using System.Linq;

namespace WyprawaNa8kPremium
{
    public class JewelsStones
    {
        // brute force
        public static int CountJewelsInStones01(string jewels, string stones)
        {
            int count = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                {
                    count++;
                }
            }

            return count;
        }

        // LINQ
        public static int CountJewelsInStones02(string jewels, string stones)
        {
            return stones.Where(x => jewels.Contains(x)).Count();
        }
    }
}
