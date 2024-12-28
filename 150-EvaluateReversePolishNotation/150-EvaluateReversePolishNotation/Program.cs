namespace _150_EvaluateReversePolishNotation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			string[] tokens = new string[] { "2", "1", "+", "3", "*" };
			Console.WriteLine(solution.EvalRPN(tokens));
		}
	}

	/*
	You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.

	Evaluate the expression. Return an integer that represents the value of the expression.

	Note that:

	The valid operators are '+', '-', '*', and '/'.
	Each operand may be an integer or another expression.
	The division between two integers always truncates toward zero.
	There will not be any division by zero.
	The input represents a valid arithmetic expression in a reverse polish notation.
	The answer and all the intermediate calculations can be represented in a 32-bit integer.
 

		Example 1:

		Input: tokens = ["2","1","+","3","*"]
		Output: 9
		Explanation: ((2 + 1) * 3) = 9
		Example 2:

		Input: tokens = ["4","13","5","/","+"]
		Output: 6
		Explanation: (4 + (13 / 5)) = 6
		Example 3:

		Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
		Output: 22
		Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
		= ((10 * (6 / (12 * -11))) + 17) + 5
		= ((10 * (6 / -132)) + 17) + 5
		= ((10 * 0) + 17) + 5
		= (0 + 17) + 5
		= 17 + 5
		= 22 

	 */

	public class Solution
	{
		public int EvalRPN(string[] tokens)
		{
			Stack<int> stack = new Stack<int>();
			foreach (var s in tokens) //iterate through the tokens
			{
				if (s == "+") //if the token is a + operator, pop the last two elements from the stack and add them together
				{
					var a = stack.Pop();
					var b = stack.Pop();
					stack.Push(a + b);
				}
				else if (s == "-") //if the token is a - operator, pop the last two elements from the stack and subtract them
				{
					var a = stack.Pop();
					var b = stack.Pop();
					stack.Push(b - a);
				}
				else if (s == "*") //if the token is a * operator, pop the last two elements from the stack and multiply them
				{
					var a = stack.Pop();
					var b = stack.Pop();
					stack.Push(a * b);
				}
				else if (s == "/") //if the token is a / operator, pop the last two elements from the stack and divide them
				{
					//Since the description says that the division between two integers always truncates toward zero, we can use integer division
					//Also the description notes that there will be no division by zero , so we don't need to check for that
					var a = stack.Pop();
					var b = stack.Pop();
					stack.Push(b / a);
				}
				else
				{
					stack.Push(int.Parse(s)); //if the token is a number, push it to the stack
				}
			}
			return stack.Pop(); //return the last element in the stack

		}
	}
}
