using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8kPremium
{
    public class Stairs
    {
        // Drzewo binarne
        public int ClimbStairs01(int n)
        {
            var result = 0;

            AddStep(0);

            void AddStep(int steps) 
            { 
                if(steps < n)
                {
                    AddStep(steps + 1);
                    AddStep(steps + 2);
                } else if( steps == n)
                {
                    result++;
                } 
            }

            return result;
        }

        // Ciąg Fibonnaciego
        public int ClimbStairs02(int n)
        {
            int Fibo(int f)
            {
                return f < 2 ? 1 : Fibo(f - 1) + Fibo(f - 2);
            }

            return Fibo(n);
        }


    }
}
