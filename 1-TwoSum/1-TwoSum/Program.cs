namespace _1_TwoSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			var numbers = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
			Console.WriteLine(numbers[0]);
			Console.WriteLine(numbers[1]);
		}
	}
	public class Solution
	{
		public int[] TwoSum(int[] nums, int target)
		{
			for (int i = nums.Length - 1; i > 0; i--)
			{
				for (int j = 0; j < i; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return new int[] { j, i };
					}
				}
			}
			return new int[] { 0, 0 };
		}

	}
}
