namespace _39_CombinationSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Solution s = new Solution();

			s.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
		}
	}

	public class Solution
	{
		public IList<IList<int>> CombinationSum(int[] candidates, int target)
		{


			IList<IList<int>> solution = new List<IList<int>>();
			Array.Sort(candidates);
			backtrack(solution, new List<int>(), candidates, target, 0);
			return solution;
		}

		public void backtrack(IList<IList<int>> solution, IList<int> tempList, int[] num, int target, int start)
		{
			if (target < 0)
			{
				return;
			}
			else if (target == 0)
			{
				solution.Add(new List<int>(tempList));
				return;
			}
			else
			{
				for (int i = start; i < num.Length; i++)
				{
					tempList.Add(num[i]);
					backtrack(solution, tempList, num, target - num[i], i);
					tempList.RemoveAt(tempList.Count - 1);
				}
			}

		}
	}
}
