using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [1,2,3,1]
    //Output: 4
    //Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
    //Total amount you can rob = 1 + 3 = 4.
    public class _198_House_Robber
    {
        public int Rob(int[] nums)
        {
            return RobRecursion(nums, 0);
        }

        private int RobRecursion(int[] nums, int start)
        {
            if (start >= nums.Length)
            {
                return 0;
            }

            int maxMoney = 0;
            for (int i = start; i <= nums.Length - 1; i++)
            {
                int money = nums[i] + RobRecursion(nums, i + 2);
                maxMoney = Math.Max(maxMoney, money);
            }

            return maxMoney;
        }

        int[] memo;
        public int Rob2(int[] nums)
        {
            memo = new int[nums.Length];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }
            return RobRecursion2(nums, 0);
        }

        private int RobRecursion2(int[] nums, int start)
        {
            if (start >= nums.Length)
            {
                return 0;
            }

            if (memo[start] != -1)
            {
                return memo[start];
            }

            int maxMoney = 0;
            for (int i = start; i <= nums.Length - 1; i++)
            {
                int money = nums[i] + RobRecursion2(nums, i + 2);
                maxMoney = Math.Max(maxMoney, money);
            }

            memo[start] = maxMoney;
            return maxMoney;
        }

        int[] dp;
        public int Rob3(int[] nums)
        {
            int len = nums.Length;
            if (len == 1)
            {
                return nums[0];
            }
            if (len == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            dp = new int[len];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i <= len - 1; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }

            return dp[len - 1];
        }
    }
}
