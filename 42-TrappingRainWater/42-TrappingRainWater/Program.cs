namespace _42_TrappingRainWater
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
	/* 
	 Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.
		
		Example 1:


		Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
		Output: 6
		Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
		Example 2:

		Input: height = [4,2,0,3,2,5]
		Output: 9
	 
	 */

	public class Solution
	{
		public int Trap(int[] height)
		{
			if (height.Length == 0)
			{
				return 0;
			}

			int left = 0;
			int right = height.Length - 1;

			int leftMax = height[left];
			int rightMax = height[right];

			int result = 0;

			while (left < right)
			{
				if (leftMax < rightMax)
				{
					left++;
					leftMax = Math.Max(leftMax, height[left]); //Determine the max height from left
					result += leftMax - height[left]; //Calculate the water trapped

				}
				else
				{
					right--;
					rightMax = Math.Max(rightMax, height[right]); //Determine the max height from right
					result += rightMax - height[right]; //Calculate the water trapped
				}
			}
			return result;


		}
	}
}
