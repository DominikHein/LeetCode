namespace _271_EncodeAndDecodeString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			var encoded = solution.Encode(new List<string> { "Hello", "World", "Bee" });
			Console.WriteLine(encoded);
			var decoded = solution.Decode(encoded);
			foreach (var s in decoded)
			{
				Console.WriteLine(s);
			}
		}
	}

	public class Solution
	{

		public string Encode(List<string> strs)
		{
			var str = "";
			foreach (var s in strs)
			{
				str += s.Length + "/" + s;
			}
			return str;
		}

		public List<string> Decode(string s)
		{
			List<string> res = new List<string>();
			int i = 0;

			while (i < s.Length)
			{
				int slash = s.IndexOf('/', i);
				int size = int.Parse(s.Substring(i, slash - i));
				res.Add(s.Substring(slash + 1, size));
				i = slash + size + 1;
			}
			return res;

		}
	}
}
