namespace _45_JumpGame2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Solution s = new Solution();
			Console.WriteLine(s.Jump(new int[] { 2, 3, 1, 1, 4 }));
		}
	}
	public class Solution
	{
		public int Jump(int[] nums)
		{
			var res = 0;
			var left = 0;
			var right = 0;

			while (right < nums.Length - 1)
			{
				var farthest = 0;
				for (var i = left; i <= right; i++)
				{
					farthest = Math.Max(farthest, i + nums[i]);
				}
				left = right + 1;
				right = farthest;
				res++;
			}
			return res;
		}
	}
}
