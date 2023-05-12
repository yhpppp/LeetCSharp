using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _414_Third_Maximum_Number
    {
        //        Input: nums = [3,2,1]
        //        Output: 1
        //Explanation:
        //The first distinct maximum is 3.
        //The second distinct maximum is 2.
        //The third distinct maximum is 1.
        public int ThirdMax(int[] nums)
        {
            System.Array.Sort(nums);
            int lastIndex = nums.Length - 1;
            int maxCount = 0;
            for (int i = lastIndex; i > 0; i--)
            {
                if (nums[i] != nums[i - 1])
                {
                    maxCount++;
                    if (maxCount == 2)
                    {
                        return nums[i - 1];
                    }
                }
            }
            //The third distinct maximum does not exist, so the maximum(2) is returned instead.
            return nums[lastIndex];
        }
    }
}
