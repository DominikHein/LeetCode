namespace _238_ProductOfArrayExceptSelf
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		public class Solution
		{
			public int[] ProductExceptSelf(int[] nums)
			{
				int[] result = new int[nums.Length];

				for (int i = 0; i < nums.Length; i++)
				{
					result[i] = 1;
					for (int j = 0; j < nums.Length; j++)
					{
						if (i != j)
						{
							result[i] *= nums[j];
						}
					}
				}
				return result;
			}
		}

		public class SolutionPrefixSuffix
		{
			public int[] ProductExceptSelf(int[] nums)
			{
				int n = nums.Length;
				int[] res = new int[n];
				Array.Fill(res, 1);

				for (int i = 1; i < n; i++)
				{
					res[i] = res[i - 1] * nums[i - 1];
				}

				int postfix = 1;
				for (int i = n - 1; i >= 0; i--)
				{
					res[i] *= postfix;
					postfix *= nums[i];
				}
				return res;
			}
		}
	}
}

