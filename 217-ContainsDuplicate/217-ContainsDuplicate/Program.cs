namespace _217_ContainsDuplicate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int[] nums = { 1, 2, 3, 1 };
			Console.WriteLine(solution.ContainsDuplicate(nums));
		}

	}

	public class Solution
	{
		public bool ContainsDuplicate(int[] nums)
		{
			Array.Sort(nums);
			if (nums.Length == 0 || nums.Length == 1)
			{
				return false;
			}

			for (int i = 0; i < nums.Length - 1; i++)
			{
				if (nums[i] == nums[i + 1])
				{
					return true;
				}
			}
			return false;
		}
	}

}
