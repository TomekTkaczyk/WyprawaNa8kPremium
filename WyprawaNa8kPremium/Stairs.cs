﻿using System;
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

        // Drzewo binarne z ograniczeniem poziomu zagłębienia
        public int ClimbStairs03(int n, int stepsCount)
        {
            var result = 0;
            int level = 0;

            AddStep(1);
            AddStep(2);

            void AddStep(int steps)
            {
                level++;
                if (steps < n)
                {
                    AddStep(steps + 1);
                    AddStep(steps + 2);
                }
                else if (steps == n)
                {
                    if (level <= stepsCount)
                    {
                        result++;
                    }
                }
                level--;
            }

            return result;
        }

        public int ClimbStairs04(int n)
        {
            static int Fibo2(int f)
            {
                int[] fibo_ = { 1, 1 }; 

                for(var i = 2; i < f + 1; i++)
                {
                    var tmp = fibo_[0];
                    fibo_[0] = fibo_[1];
                    fibo_[1] = tmp + fibo_[0];
                }

                return fibo_[1];
            }

            return Fibo2(n);
        }
    }
}
