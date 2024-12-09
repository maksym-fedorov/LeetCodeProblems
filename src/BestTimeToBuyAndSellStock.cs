namespace LeetCode.Problems
{
    public sealed class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int buy = prices[0];
            int sell = prices[prices.Length - 1];
            int maxProfit = sell > buy ? sell - buy : 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                    sell = 0;
                }
                else if (prices[i] > sell)
                {
                    sell = prices[i];
                    int profit = sell - buy;

                    if (maxProfit < profit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }
    }
}
