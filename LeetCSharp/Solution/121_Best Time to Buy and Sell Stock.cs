using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: prices = [7,1,5,3,6,4]
    //Output: 5
    //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    public class _121_Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }
            return maxProfit;
        }
        public int MaxProfit2(int[] prices)
        {
            int cost = int.MaxValue;
            int profit = 0;
            //[7,1,5,3,6,4]
            foreach (int price in prices)
            {
                //7 1 1 1 1
                cost = Math.Min(cost, price);
                //0 0 4 2 5
                profit = Math.Max(profit, price - cost);
            }
            return profit;
        }

        int[,] dp;
        public int MaxProfit3(int[] prices)
        {
            int len = prices.Length;
            int[,] dp = new int[len, 2];
            dp[0, 0] = 0;

            dp[0, 1] = -prices[0];

            for (int i = 1; i < len; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], -prices[i]);
            }
            return dp[len - 1, 0];
        }

    }
}
