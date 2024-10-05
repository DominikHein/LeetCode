namespace _2491_DividePlayersIntoTeamsOfEqualSkill
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Solution solution = new Solution();

			var fairmatchmaking = solution.DividePlayers(new int[] { 5, 10, 15, 20, 25, 30 });

			Console.WriteLine(fairmatchmaking);
		}
	}
	public class Solution
	{
		public long DividePlayers(int[] skill)
		{
			int groups = skill.Length / 2;

			int skillSum = skill.Sum();


			List<List<int>> teams = new List<List<int>>();

			Array.Sort(skill);

			int targetSkill = skillSum / groups;
			int chemistry = 0;

			int left = 0;
			int right = skill.Length - 1;

			while (left < right)
			{
				if (skill[left] + skill[right] != targetSkill)
				{
					return -1;
				}

				chemistry += skill[left] * skill[right];

				left++;
				right--;
			}

			return chemistry;
		}

	}
}

