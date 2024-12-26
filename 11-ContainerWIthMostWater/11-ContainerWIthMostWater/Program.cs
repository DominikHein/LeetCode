namespace _11_ContainerWIthMostWater
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Solution solution = new Solution();
			Console.WriteLine(solution.MaxArea([1, 7, 2, 5, 12, 3, 500, 500, 7, 8, 4, 7, 3, 6]));
		}
	}

	/*You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

	Find two lines that together with the x-axis form a container, such that the container contains the most water.

	Return the maximum amount of water a container can store.

	Notice that you may not slant the container.

			Example 1:
			Input: height = [1,8,6,2,5,4,8,3,7]
			Output: 49
			Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
			Example 2:

			Input: height = [1,1]
			Output: 1
	*/

	public class Solution
	{
		public int MaxArea(int[] height)
		{
			int res = 0;
			int l = 0; int r = height.Length - 1;

			while (l < r)
			{
				int area = (Math.Min(height[l], height[r])) * (r - l); // width * height
				res = Math.Max(area, res); // checking if the current area is greater than the previous area
				if (height[l] < height[r]) // Two Pointer Solution
				{
					l++;
				}
				else
				{
					r--;
				}
			}
			return res;
		}
	}
}
