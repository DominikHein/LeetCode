namespace _347_TopKFrequentElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}

	public class Solution
	{
		public int[] TopKFrequent(int[] nums, int k)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			List<int>[] freq = new List<int>[nums.Length + 1];

			for (int i = 0; i < freq.Length; i++)
			{
				freq[i] = new List<int>();
			}

			foreach (int n in nums)
			{
				if (!dict.ContainsKey(n))
				{
					dict[n] = 1;
				}
				else
				{
					dict[n]++;
				}
			}

			foreach (var item in dict)
			{
				freq[item.Value].Add(item.Key);
			}

			int[] res = new int[k];
			int index = 0;
			for (int i = freq.Length - 1; i >= 0; i--)
			{
				if (freq[i].Count > 0)
				{
					foreach (int n in freq[i])
					{
						res[index++] = n;
						if (index == k)
						{
							return res;
						}
					}
				}
			}
			return res;
		}
	}
}
