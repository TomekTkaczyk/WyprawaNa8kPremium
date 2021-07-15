using System;
using System.Collections.Generic;

namespace WyprawaNa8kPremium
{
    public class Thief
    {
        public int Rob(int[] houseValueArray)
        {
            var (sumWithoutCurrentHouse, sumWithCurrentHouse) = GetRouteSummary(houseValueArray.Length-1);

            return Math.Max(sumWithoutCurrentHouse, sumWithCurrentHouse);

            (int sumWithoutCurrentHouse, int sumWithCurrentHouse) GetRouteSummary(int n)
            {
                if(n == 0)
                {
                    return (0, houseValueArray[0]);
                }

                var previous = GetRouteSummary(n - 1);
                var maxPrevoius = Math.Max(previous.sumWithoutCurrentHouse, previous.sumWithCurrentHouse);
                var maxCurrent = previous.sumWithoutCurrentHouse + houseValueArray[n];

                return (maxPrevoius, maxCurrent);
            }
        }

        public int Rob1(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int rob = 0;  // max if rob current house;
            int notRob = 0; // max if not rob current house;
            for (int i = 0; i < nums.Length; i++)
            {
                int curRob = notRob + nums[i];
                //if not rob ith house, take the max value 
                // of notRob or rob for previous house
                notRob = Math.Max(notRob, rob);
                rob = curRob;
            }
            return Math.Max(rob, notRob);
        }
    }
}
