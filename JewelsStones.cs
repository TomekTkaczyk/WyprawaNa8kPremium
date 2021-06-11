using System.Collections;
using System.Collections.Generic;
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

        // LINQ Queries
        public static int CountJewelsInStones03(string jewels, string stones)
        {
            return (from s in stones
                    group s by s into stone
                    where jewels.Contains(stone.Key)
                    select stone.Count()
                    ).Sum();
        }

        // ToHasSet
        public static int CountJewelsInStones04(string jewels, string stones)
        {
            Dictionary<char,int> stoneHash = stones.ToHashSet().ToDictionary(y => y, y => 0);
            stones.ToList().ForEach(x => stoneHash[x]++);

            return jewels.ToList().Where(x => stoneHash.ContainsKey(x)).Select(x => stoneHash[x]).Sum();
        }
    }
}
