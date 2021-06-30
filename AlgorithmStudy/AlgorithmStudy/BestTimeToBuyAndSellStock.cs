/*
 * Algorithm Day 1
 * BestTimeToBuyAndSellStock
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 * 
 * 44.87% 속도
 */

namespace BestTimeToBuyAndSellStock
{
    class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int minValue = prices[0];
            int maxValue = prices[0];
            int maxProfitValue = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if(prices[i] < minValue)
                {
                    minValue = prices[i];
                    maxValue = 0;
                    continue;
                }

                if(prices[i] > maxValue)
                {
                    maxValue = prices[i];

                    if(maxProfitValue < maxValue - minValue)
                    {
                        maxProfitValue = maxValue - minValue;
                    }
                }
            }
            return maxProfitValue;
        }
    }
}
