using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCSharp.Solution
{
    //Input: nums = [1,4,3,2]
    //Output: 4
    //Explanation: All possible pairings(ignoring the ordering of elements) are:
    //1. (1, 4), (2, 3) -> min(1, 4) + min(2, 3) = 1 + 2 = 3
    //2. (1, 3), (2, 4) -> min(1, 3) + min(2, 4) = 1 + 2 = 3
    //3. (1, 2), (3, 4) -> min(1, 2) + min(3, 4) = 1 + 3 = 4
    //So the maximum possible sum is 4.
    public class _561_Array_Partition
    {
        public int ArrayPairSum(int[] nums)
        {
            System.Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
