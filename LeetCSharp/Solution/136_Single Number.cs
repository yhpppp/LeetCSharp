using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [2,2,1]
    //Output: 1
    public class _136_Single_Number
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var item in nums)
            {
                result = result ^ item;
            }
            return result;
        }
    }
}
