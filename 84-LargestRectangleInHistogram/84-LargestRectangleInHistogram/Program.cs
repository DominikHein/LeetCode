namespace _84_LargestRectangleInHistogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var area = sol.LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 });
            Console.WriteLine(area);

            StackSolution stackSol = new StackSolution();
            area = sol.LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 });
            Console.WriteLine(area);
        }
    }
    //Brute Force
    public class Solution
    {
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            int maxArea = 0;

            for (int i = 0; i < n; i++)
            {
                int height = heights[i];

                //Move right until height is greater than current hight
                int rightMost = i + 1;
                while (rightMost < n && heights[rightMost] >= height)
                {
                    rightMost++;
                }

                //Move left until height is greater than current hight
                int leftMost = i;
                while (leftMost >= 0 && heights[leftMost] >= height)
                {
                    leftMost--;
                }

                rightMost--;
                leftMost++;
                //Calculate area
                maxArea = Math.Max(maxArea, height * (rightMost - leftMost + 1));
            }
            return maxArea;
        }
    }

    //Stack Solution 
    public class StackSolution
    {
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            int[] leftMost = new int[n];
            int[] rightMost = new int[n];
            Stack<int> stack = new Stack<int>();

            //Find most left index for each element
            for (int i = 0; i < n; i++)
            {
                leftMost[i] = -1;
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                {
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    leftMost[i] = stack.Peek();
                }
                stack.Push(i);
            }

            stack.Clear();

            //Find most right index for each element
            for (int i = n - 1; i >= 0; i--)
            {
                rightMost[i] = n;
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                {
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    rightMost[i] = stack.Peek();
                }
                stack.Push(i);
            }

            int maxArea = 0;
            //Calculate area
            for (int i = 0; i < n; i++)
            {
                leftMost[i] += 1;
                rightMost[i] -= 1;
                maxArea = Math.Max(maxArea, heights[i] * (rightMost[i] - leftMost[i] + 1));
            }

            return maxArea;
        }
    }

}
