// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

namespace Solutions
{
    public class BestTimeToBuyStock
    {
        public int MaxProfit(int[] prices)
        {
            int minSoFar = prices[0];
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                minSoFar = Math.Min(minSoFar, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minSoFar);

            }
            return maxProfit;
        }
    }
}
