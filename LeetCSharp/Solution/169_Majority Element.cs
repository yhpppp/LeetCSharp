using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [3,2,3]
    //Output: 3
    public class _169_Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;
            foreach (var item in nums)
            {
                if (count == 0)
                {
                    candidate = item;
                }
                count += item == candidate ? 1 : -1;
            }
            return candidate;
        }
    }
}
