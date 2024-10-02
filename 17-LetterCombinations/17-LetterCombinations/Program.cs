namespace _17_LetterCombinations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Console.WriteLine();
			Program program = new Program();
			IList<string> result = program.LetterCombinations("23");

			foreach (string item in result)
			{
				Console.WriteLine(item);
			}
		}
		public IList<string> LetterCombinations(string digits)
		{
			List<String> ans = new List<string>();
			if (digits.Length == 0)
			{
				return new List<string>();
			}

			int i = 0;

			string output = "";

			string[] mapping = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

			solve(digits, i, output, ans, mapping);
			return ans;
		}

		private void solve(string digits, int i, string output, List<string> ans, string[] mapping)
		{

			if (i >= digits.Length)
			{
				ans.Add(output);
				return;
			}

			int num = digits[i] - '0';
			string letters = mapping[num];

			for (int j = 0; j < letters.Length; j++)
			{
				solve(digits, i + 1, output + letters[j], ans, mapping);

			}
		}
	}
}
