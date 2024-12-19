namespace _167._Two_Sum_II___Input_Array_Is_Sorted
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
		public int[] TwoSum(int[] numbers, int target)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (numbers[i] + numbers[j] == target)
					{
						return new int[] { i + 1, j + 1 };

					}
					else if (numbers[i] + numbers[j] > target)
					{
						break;
					}
				}
			}
			return new int[] { 0, 0 };
		}

		public int[] TwoSumTwoPointers(int[] numbers, int target)
		{
			int left = 0;
			int right = numbers.Length - 1;

			while (left < right)
			{
				int sum = numbers[left] + numbers[right];
				if (sum == target)
				{
					return new int[] { left + 1, right + 1 };
				}
				else if (sum < target)
				{
					left++;
				}
				else
				{
					right--;
				}
			}
			return new int[] { 0, 0 };
		}
	}
}
