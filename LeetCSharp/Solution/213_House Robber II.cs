using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [2,3,2]
    //Output: 3
    //Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.
    public class _213_House_Robber_II
    {
        public int Rob(int[] nums)
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
            return Math.Max(RobRecursion(nums, 0, len - 2), RobRecursion(nums, 1, len - 1));
        }

        private int RobRecursion(int[] nums, int start, int end)
        {
            if (start >= nums.Length)
            {
                return 0;
            }
            int res = 0;
            for (int i = start; i <= end; i++)
            {
                res = Math.Max(res, nums[i] + RobRecursion(nums, i + 2, end));
            }

            return res;
        }

        int[] memo;
        public int Rob2(int[] nums)
        {
            memo = new int[nums.Length];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }

            int len = nums.Length;
            if (len == 1)
            {
                return nums[0];
            }
            if (len == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            int maxMoney1 = RobRecursion2(nums, 0, len - 2);
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }
            int maxMoney2 = RobRecursion2(nums, 1, len - 1);
            return Math.Max(maxMoney1, maxMoney2);
        }

        private int RobRecursion2(int[] nums, int start, int end)
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
            for (int i = start; i <= end; i++)
            {
                int money = nums[i] + RobRecursion2(nums, i + 2, end);
                maxMoney = Math.Max(maxMoney, money);
            }
            memo[start] = maxMoney;
            return maxMoney;
        }

        int[] dp;
        public int Rob3(int[] nums)
        {
            int len = nums.Length;
            dp = new int[len];
            if (len == 1)
            {
                return nums[0];
            }
            if (len == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }


            return Math.Max(RobRange(nums, 0, nums.Length - 2), RobRange(nums, 1, nums.Length - 1));
        }

        private int RobRange(int[] nums, int start, int end)
        {
            dp[start] = nums[start];
            dp[start + 1] = Math.Max(nums[start], nums[start + 1]);

            for (int i = start + 2; i <= end; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }
            return dp[end];
        }
    }
}
