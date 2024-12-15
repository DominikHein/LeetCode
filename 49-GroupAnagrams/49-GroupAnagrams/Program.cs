namespace _49_GroupAnagrams
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
			var res = solution.GroupAnagrams(strs);
			foreach (var r in res)
			{
				Console.WriteLine(string.Join(",", r));
			}
		}
	}

	public class Solution
	{
		public IList<IList<string>> GroupAnagrams(string[] strs)
		{
			var res = new Dictionary<string, List<string>>();
			foreach (var s in strs)
			{
				int[] count = new int[26];
				foreach (char c in s)
				{
					count[c - 'a']++; //Zählt die Häufigkeit der Buchstaben (C - 'a' gibt den Index des Buchstaben im Alphabet zurück)
				}
				string key = string.Join(",", count);
				if (!res.ContainsKey(key)) //Wenn der Schlüssel noch nicht im Dictionary ist, wird er hinzugefügt
				{
					res[key] = new List<string>(); //Erstellt eine neue Liste
				}
				res[key].Add(s); //Fügt das Wort zur Liste hinzu
			}
			return res.Values.ToList<IList<string>>();
		}
	}
}
