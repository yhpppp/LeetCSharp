using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: prices = [7,1,5,3,6,4]
    //Output: 7
    //Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
    //Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
    //Total profit is 4 + 3 = 7.
    public class _122_Best_Time_to_Buy_and_Sell_Stock_II
    {
        int[,] dp;
        public int MaxProfit(int[] prices)
        {
            int len = prices.Length;
            int[,] dp = new int[len, 2];
            dp[0, 0] = 0;
            dp[0, 1] = -prices[0];
            for (int i = 1; i < len; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], -prices[i] + dp[i - 1, 0]);
            }
            return dp[len - 1, 0];
        }
    }
}
