namespace _242_ValidAnagram
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Solution solution = new Solution();
			Console.WriteLine(solution.IsAnagram("anagram", "nagaram"));
			Console.WriteLine(solution.IsAnagram2("anagram", "nagaram"));
		}
	}

	public class Solution()
	{
		//Horrible Time Complexity
		public bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;

			}

			for (int i = 0; i < s.Length; i++)
			{
				for (int j = 0; j < t.Length; j++)
				{
					if (s[i] == t[j])
					{
						t = t.Remove(j, 1);
						break;
					}
				}
				if (t.Length == 0)
				{
					return true;
				}
			}
			return false;
		}

		//Better Time Complexity
		public bool IsAnagram2(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;
			}

			char[] sArray = s.ToCharArray();
			char[] tArray = t.ToCharArray();
			Array.Sort(sArray);
			Array.Sort(tArray);

			if (sArray.SequenceEqual(tArray))
			{
				return true;
			}
			else
			{
				return false;
			}

		}
	}

}
