using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    public class _27_Remove_Element
    {
        //Input: nums = [3,2,2,3], val = 3
        //Output: 2, nums = [2,2, _, _]
        //Explanation: Your function should return k = 2, with the first two elements of nums being 2.
        //It does not matter what you leave beyond the returned k(hence they are underscores).
        public int RemoveElement1(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }

        //Note that the five elements can be returned in any order.
        public int RemoveElement2(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length;
            while (i < j)
            {
                if (nums[i] == val)
                {
                    j--;
                    nums[i] = nums[j];
                }else
                {
                    i++;
                }
            }
            return i;
        }
    }
}
