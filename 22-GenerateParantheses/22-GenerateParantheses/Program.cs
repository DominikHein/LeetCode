namespace _22_GenerateParantheses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Solution solution = new Solution();
			solution.GenerateParenthesis(1);
		}
	}

	public class Solution
	{
		public IList<string> GenerateParenthesis(int n)
		{
			IList<string> result = new List<string>();
			Recurse(result, 0, 0, "", n);
			Console.WriteLine(result[0]);

			return result;
		}

		public void Recurse(IList<string> result, int left, int right, String s, int n)
		{
			if (s.Length == n * 2)
			{
				result.Add(s);
				return;
			}

			if (left < n)
			{
				Recurse(result, left + 1, right, s + "(", n);
			}
			if (right < left)
			{
				Recurse(result, left, right + 1, s + ")", n);
			}
		}
	}
}
