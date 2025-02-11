namespace _853_CarFleet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int target = 12;
			int[] position = new int[] { 10, 8, 0, 5, 3 };
			int[] speed = new int[] { 2, 4, 1, 1, 3 };
			int result = solution.CarFleet(target, position, speed);
			Console.WriteLine(result);

		}

		public class Solution
		{
			public int CarFleet(int target, int[] position, int[] speed)
			{
				int[][] pair = new int[position.Length][];
				for (int i = 0; i < position.Length; i++)
				{
					pair[i] = new int[] { position[i], speed[i] }; // pair of position and speed for each car
				}
				Array.Sort(pair, (a, b) => b[0].CompareTo(a[0])); // sorting by position
				Stack<double> stack = new Stack<double>(); // stack for time taken to reach target
				foreach (var p in pair)
				{
					stack.Push((double)(target - p[0]) / p[1]); // time = distance/speed
					if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) // if car behind reaches the target before the car in front
					{
						stack.Pop(); // remove the car in front
					}
				}
				return stack.Count; // return number of cars that reached the target
			}
		}
	}
}
