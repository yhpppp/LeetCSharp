using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [2,7,11,15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    public class _1_Two_Sum
    {
        //O(n^2)
        public int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic[nums[i]] = i;
                int secondNum = target - nums[i];
                if (dic.ContainsKey(secondNum) && dic[secondNum] != i)
                {
                    return new int[] { i, dic[secondNum] };
                }
            }

            return new int[] { };
        }
    }
}
