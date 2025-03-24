namespace _704_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));

        }
    }
    /*
    Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

    You must write an algorithm with O(log n) runtime complexity.

    Example 1:

    Input: nums = [-1,0,3,5,9,12], target = 9
    Output: 4
    Explanation: 9 exists in nums and its index is 4
    Example 2:

    Input: nums = [-1,0,3,5,9,12], target = 2
    Output: -1
    Explanation: 2 does not exist in nums so return -1
    */


    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                int m = l + ((r - l) / 2); // calculating middle index
                if (nums[m] > target) // if middle element is greater than target, then we need to search in left half
                {
                    r = m - 1; // setting right pointer to middle - 1
                }
                else if (nums[m] < target) // if middle element is less than target, then we need to search in right half
                {
                    l = m + 1; // setting left pointer to middle + 1
                }
                else
                {
                    return m; // if middle element is equal to target, then return the index
                }
            }
            return -1;
        }

    }
}


