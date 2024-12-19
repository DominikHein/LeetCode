namespace _125_ValidPalindrome
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Solution solution = new Solution();
			Console.WriteLine(solution.IsPalindrome("A man, a plan, a canal: Panama"));
		}
	}
	public class Solution
	{
		public bool IsPalindrome(string s)
		{
			s = s.ToLower();
			s = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray());
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] != s[s.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
