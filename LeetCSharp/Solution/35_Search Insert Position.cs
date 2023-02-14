using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Example 1:
    //Input: nums = [1,3,5,6], target = 5
    //Output: 2

    //Example 2:
    //Input: nums = [1,3,5,6], target = 2
    //Output: 1
    public class _35_Search_Insert_Position
    {
        public int SearchInsert(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            int notfountValue = 0;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    l = notfountValue = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    r = mid - 1;
                }
            }

            return notfountValue;
        }
    }
}
