namespace _15_3Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Solution solution = new Solution();
			//solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
			foreach (var item in solution.ThreeSum(new int[] { -2, 0, 0, 2, 2 }))
			{
				foreach (var i in item)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
	public class Solution
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			Array.Sort(nums);

			IList<IList<int>> result = new List<IList<int>>();

			for (int i = 0; i < nums.Length; i++)
			{
				if (i > 0 && nums[i] == nums[i - 1] || i == 0)
				{
					int l = i + 1, r = nums.Length - 1;
					while (l < r)
					{
						var sum = nums[i] + nums[l] + nums[r];
						if (sum == 0)
						{
							result.Add(new List<int> { nums[i], nums[l], nums[r] });
							l++;
							r--;

							while (l < r && nums[l] == nums[l - 1]) l++;
							while (l < r && nums[r] == nums[r + 1]) r--;

						}
						else if (sum < 0)
						{
							l++;
						}
						else if (sum > 0)
						{
							r--;
						}
					}
				}

			}
			return result;
		}
	}
}
