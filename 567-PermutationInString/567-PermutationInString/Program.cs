namespace _567_PermutationInString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Solution solution = new Solution();

			var sol = solution.CheckInclusion("ab", "ba");

			Console.WriteLine(sol);
		}

		public class Solution
		{

			public bool CheckInclusion(string s1, string s2)
			{
				if (s1.Length > s2.Length || s2.Length == 0) return false;
				if (s1.Length == 0) return true;


				int x = s1.Length;
				int y = s2.Length;

				int[] s1Map = new int[26];
				int[] s2Map = new int[26];

				for (int i = 0; i < x; i++)
				{
					s1Map[s1[i] - 'a']++;
					s2Map[s2[i] - 'a']++;
				}

				for (int i = 0; i < y - x; i++)
				{
					if (AreMapsEqual(s1Map, s2Map))
					{
						return true;
					}

					s2Map[s2[i] - 'a']--;
					s2Map[s2[i + x] - 'a']++;
				}
				if (AreMapsEqual(s1Map, s2Map))
				{
					return true;
				}
				else return false;

			}
			private bool AreMapsEqual(int[] s1Map, int[] s2Map)
			{
				for (int i = 0; i < 26; i++)
				{
					if (s1Map[i] != s2Map[i])
					{
						return false;
					}
				}
				return true;
			}
		}
	}
}

