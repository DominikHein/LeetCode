﻿namespace _155_MinStack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MinStack minStack = new MinStack();
			minStack.Push(-2);
			minStack.Push(0);
			minStack.Push(-3);
			Console.WriteLine(minStack.GetMin()); // return -3
		}
	}

	/*
	
	Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

	Implement the MinStack class:

	MinStack() initializes the stack object.
	void push(int val) pushes the element val onto the stack.
	void pop() removes the element on the top of the stack.
	int top() gets the top element of the stack.
	int getMin() retrieves the minimum element in the stack.
	You must implement a solution with O(1) time complexity for each function.

 

	Example 1:

	Input
	["MinStack","push","push","push","getMin","pop","top","getMin"]
	[[],[-2],[0],[-3],[],[],[],[]]

	Output
	[null,null,null,null,-3,null,0,-2]

	Explanation
	MinStack minStack = new MinStack();
	minStack.push(-2);
	minStack.push(0);
	minStack.push(-3);
	minStack.getMin(); // return -3
	minStack.pop();
	minStack.top();    // return 0
	minStack.getMin(); // return -2

	 */

	public class MinStack
	{
		private Stack<int> stack;
		private Stack<int> minStack;

		public MinStack()
		{
			stack = new Stack<int>();
			minStack = new Stack<int>();
		}

		public void Push(int val)
		{
			stack.Push(val); // Pushing value into stack

			//Checking if value is less than the minstack value 
			//If minstack value is empty or value is less than minstack value then push the value into minstack
			val = Math.Min(val, minStack.Count == 0 ? val : minStack.Peek());
			minStack.Push(val); //Pushing smallest value into minstack
		}

		public void Pop()
		{
			stack.Pop(); //popping stack
			minStack.Pop(); //popping minstack
		}

		public int Top()
		{
			return stack.Peek(); //returning top value of stack
		}

		public int GetMin()
		{
			return minStack.Peek(); //returning smallest value of stacks:
									//since we are only pushing the smallest value into minstack the top value will always be the smallest value
		}
	}

}
