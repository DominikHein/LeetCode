namespace _515_FindLargestValueInEachTreeRow
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution.TreeNode root = new Solution.TreeNode(1);
			root.left = new Solution.TreeNode(3);
			root.right = new Solution.TreeNode(2);
			root.left.left = new Solution.TreeNode(5);
			root.left.right = new Solution.TreeNode(3);
			root.right.left = new Solution.TreeNode(0);
			root.right.right = new Solution.TreeNode(9);

			Solution sol = new Solution();
			var result = sol.LargestValues(root);

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}

	/*
	 Given the root of a binary tree, return an array of the largest value in each row of the tree (0-indexed).

		Example 1:


		Input: root = [1,3,2,5,3,null,9]
		Output: [1,3,9]
		Example 2:

		Input: root = [1,2,3]
		Output: [1,3]
	 */

	public class Solution
	{
		public IList<int> LargestValues(TreeNode root)
		{
			if (root == null) //If Tree is empty return empty list
				return new List<int>();

			List<int> result = new List<int>();
			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			//Iterate through the tree
			while (queue.Count > 0)
			{
				int curr_level_size = queue.Count; //Getting the size of the current level
				int max_val = Int32.MinValue; //Setting the max value to the minimum value of an integer

				for (int i = 0; i < curr_level_size; i++) //Going through the current level
				{
					TreeNode curr_node = queue.Dequeue(); //Dequeue the current node into curr_node
					max_val = Math.Max(max_val, curr_node.val); //Checking if current node is greater than max_val

					if (curr_node.left != null) //If left child is not null, enqueue it
						queue.Enqueue(curr_node.left);

					if (curr_node.right != null) //If right child is not null, enqueue it
						queue.Enqueue(curr_node.right);
				}

				result.Add(max_val); //Adding the max value to result list
			}
			return result;
		}

		//Definition for a binary tree node.
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}
		}
	}
}
