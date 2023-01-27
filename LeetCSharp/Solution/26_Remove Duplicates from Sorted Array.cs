using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    public class _26_Remove_Duplicates_from_Sorted_Array
    {
        //Input: nums = [0,0,1,1,1,2,2,3,3,4]
        //Output: 5, nums = [0,1,2,3,4, _, _, _, _, _]
        public int RemoveDuplicates(int[] nums)
        {
            int j = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
    }
}
