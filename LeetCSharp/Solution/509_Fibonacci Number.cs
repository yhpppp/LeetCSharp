using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _509_Fibonacci_Number
    {
        public int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }


        private int[] memo;
        public int Fib2(int n)
        {
            memo = new int[n + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }
            return CalcFib(n);
        }

        private int CalcFib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            if (memo[n] == -1)
            {
                memo[n] = CalcFib(n - 1) + CalcFib(n - 2);
            }
            return memo[n];
        }

        int[] dp;
        public int Fib3(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
