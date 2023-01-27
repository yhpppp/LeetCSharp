using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    //Input: nums = [-1,0,3,5,9,12], target = 9
    //Output: 4
    //Explanation: 9 exists in nums and its index is 4
    public class _704_Binary_Search
    {
        public int Search1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Search2(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int midIndex = l + (r - l) / 2;
                int midValue = nums[midIndex];
                if (midValue == target)
                {
                    return midIndex;
                }
                else if (midValue < target)
                {
                    l = midIndex + 1;
                }
                else
                {
                    r = midIndex - 1;

                }
            }
            return -1;
        }
    }
}
