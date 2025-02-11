namespace _739_Daily_Temperatures
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int[] temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
			foreach (var item in solution.DailyTemperatures(temperatures))
			{
				Console.WriteLine(item);
			}
		}
	}

	public class Solution
	{
		public int[] DailyTemperatures(int[] temperatures)
		{
			Stack<int> stack = new Stack<int>();
			int[] result = new int[temperatures.Length];

			for (int i = 0; i < temperatures.Length; i++)
			{
				while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) // if current temperature is greater than the next temperature
				{
					int index = stack.Pop(); // pop the top element
					result[index] = i - index; // calculate the difference between the current index and the popped index
				}

				stack.Push(i);
			}

			return result;
		}
	}
}
