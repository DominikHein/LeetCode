namespace _20_ValidParentheses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			Console.WriteLine(solution.IsValid("()[]{}"));

			StackSolution stackSolution = new StackSolution();
			Console.WriteLine(stackSolution.IsValid("(()({[]}))"));
		}
	}

	/*
	Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

	An input string is valid if:

	Open brackets must be closed by the same type of brackets.
	Open brackets must be closed in the correct order.
	Every close bracket has a corresponding open bracket of the same type.
 

		Example 1:

		Input: s = "()"

		Output: true

		Example 2:

		Input: s = "()[]{}"

		Output: true

		Example 3:

		Input: s = "(]"

		Output: false

		Example 4:

		Input: s = "([])"

		Output: true

	 */
}

public class Solution //Brute force attempt
{
	public bool IsValid(string s)
	{
		while (s.Contains("()") || s.Contains("[]") || s.Contains("{}")) //While there are still pairs of brackets to remove
		{
			s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");//Replace the pairs with an empty string
		}
		if (s.Length == 0) //If the string is empty, return true
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

public class StackSolution
{
	public bool IsValid(string s)
	{
		Stack<char> stack = new Stack<char>();
		Dictionary<char, char> bracketPairs = new Dictionary<char, char> //Dictionary to store the pairs of brackets
		{
			{')', '('},
			{']', '['},
			{'}', '{'}
		};

		foreach (char c in s)
		{
			if (bracketPairs.ContainsKey(c)) //If the character is a closing bracket
			{
				if (stack.Count > 0 && stack.Peek() == bracketPairs[c]) // If the stack is not empty and on the top of the stack is the corresponding opening bracket
				{
					stack.Pop(); //Removing the opening bracket from the stack 
				}
				else // If the opening bracket doesn't match the closing bracket
				{
					return false; //Return false
				}
			}
			else //If the character is an opening bracket 
			{
				stack.Push(c); //add it to the stack
			}
		}
		//If the stack is empty return true
		return stack.Count == 0;
	}
}

