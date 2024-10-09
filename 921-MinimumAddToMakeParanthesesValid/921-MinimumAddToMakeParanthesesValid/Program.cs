namespace _921_MinimumAddToMakeParanthesesValid
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Solution solution = new Solution();

			var sol = solution.MinAddToMakeValid("())");
			Console.WriteLine(sol);
		}
	}

	public class Solution
	{
		public int MinAddToMakeValid(string s)
		{
			var stackOpen = 0;
			var stackClose = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					stackOpen++;
				}
				else
				{
					if (stackOpen > 0)
					{
						stackOpen--;
					}
					else
					{
						stackClose++;
					}
				}
			}
			return stackOpen + stackClose;
		}
	}
}
