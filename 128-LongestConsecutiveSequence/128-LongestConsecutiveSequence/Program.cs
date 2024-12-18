namespace _128_LongestConsecutiveSequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Solution solution = new Solution();
			int[] nums = [2, 20, 4, 10, 3, 4, 5];
			Console.WriteLine(solution.LongestConsecutive(nums));
		}
	}

	public class Solution
	{
		public int LongestConsecutive(int[] nums)
		{
			HashSet<int> num_set = new HashSet<int>(nums);
			int longest = 0;

			foreach (int num in num_set)
			{
				if (!num_set.Contains(num - 1))
				{
					int length = 1;

					while (num_set.Contains(num + length))
					{
						length++;
					}

					longest = Math.Max(longest, length);
				}
			}
			return longest;
		}
	}
}
