using System;
using System.Collections.Generic;

namespace WyprawaNa8kPremium
{
    public class Thief
    {
        public int Rob(int[] houseValueArray)
        {
            var (sumWithoutCurrentHouse, sumWithCurrentHouse) = GetRouteSummaryValue(houseValueArray.Length-1);

            return Math.Max(sumWithoutCurrentHouse, sumWithCurrentHouse);

            (int sumWithoutCurrentHouse, int sumWithCurrentHouse) GetRouteSummaryValue(int n)
            {
                if(n == 0)
                {
                    return (0, houseValueArray[0]);
                }

                var previous = GetRouteSummaryValue(n - 1);
                var maxPrevoius = Math.Max(previous.sumWithoutCurrentHouse, previous.sumWithCurrentHouse);
                var maxCurrent = previous.sumWithoutCurrentHouse + houseValueArray[n];

                return (maxPrevoius, maxCurrent);
            }
        }
    }
}
