using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: n = 3
    //Output: 3
    //Explanation: There are three ways to climb to the top.
    //1. 1 step + 1 step + 1 step
    //2. 1 step + 2 steps
    //3. 2 steps + 1 step
    public class _70_Climbing_Stairs
    {
        //public int ClimbStairs(int n)
        //{
        //    if (n == 1) { return 1; }
        //    if (n == 2) { return 2; }

        //    int[] ints = new int[n];
        //    ints[0] = 1;
        //    ints[1] = 2;

        //    for (int i = 2; i < n; i++)
        //    {
        //        ints[i] = ints[i - 2] + ints[i - 1];
        //    }

        //    return ints[n - 1];
        //}
        // time out
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
        private int[] memo;
        public int ClimbStairs2(int n)
        {
            memo = new int[n + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }
            return CalcClimbStairs(n);
        }

        private int CalcClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }
            if (memo[n] == -1)
            {
                memo[n] = CalcClimbStairs(n - 1) + CalcClimbStairs(n - 2);
            }
            return memo[n];
        }

        public int ClimbStairs3(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
