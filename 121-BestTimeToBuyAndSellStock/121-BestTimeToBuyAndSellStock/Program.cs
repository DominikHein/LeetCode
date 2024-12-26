namespace _121_BestTimeToBuyAndSellStock
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			Console.WriteLine(solution.MaxProfit([7, 1, 5, 3, 6, 4]));
		}
	}
	/* 
	 You are given an integer array prices where prices[i] is the price of NeetCoin on the ith day.

	You may choose a single day to buy one NeetCoin and choose a different day in the future to sell it.

	Return the maximum profit you can achieve. You may choose to not make any transactions, in which case the profit would be 0.

		Example 1:

		Input: prices = [10,1,5,6,7,1]

		Output: 6
		Explanation: Buy prices[1] and sell prices[4], profit = 7 - 1 = 6.

		Example 2:

		Input: prices = [10,8,7,5,2]

		Output: 0
		Explanation: No profitable transactions can be made, thus the max profit is 0.
	 */
	public class Solution
	{
		public int MaxProfit(int[] prices)
		{
			int maxProfit = 0;
			int minbuy = prices[0];

			foreach (int sell in prices) // sell is the current price
			{
				maxProfit = Math.Max(maxProfit, sell - minbuy); // sell - minbuy is the profit if profit is higher than maxProfix go on with that 
				minbuy = Math.Min(minbuy, sell); // if the current price is lower than the minbuy, update the minbuy
			}

			return maxProfit;

		}
	}
}
