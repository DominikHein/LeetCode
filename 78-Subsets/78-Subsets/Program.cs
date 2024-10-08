namespace _78_Subsets
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Solution s = new Solution();

			var solution = s.Subsets(new int[] { 1, 2, 3 });

			Console.WriteLine(solution);
		}
	}

	public class Solution
	{
		public IList<IList<int>> Subsets(int[] nums)
		{
			IList<IList<int>> res = new List<IList<int>>();
			backtracking(nums, res, 0, new List<int>());
			return res;
		}

		public void backtracking(int[] nums, IList<IList<int>> res, int index, List<int> cur)
		{
			res.Add(new List<int>(cur));

			for (int i = index; i < nums.Length; i++)
			{
				cur.Add(nums[i]);
				backtracking(nums, res, i + 1, cur);
				cur.RemoveAt(cur.Count - 1);
			}
		}

	}
}
