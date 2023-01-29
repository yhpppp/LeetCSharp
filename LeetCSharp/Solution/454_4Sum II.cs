using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums1 = [1,2], nums2 = [-2,-1], nums3 = [-1,2], nums4 = [0,2]
    //Output: 2
    //Explanation:
    //The two tuples are:
    //1. (0, 0, 0, 1) -> nums1[0] + nums2[0] + nums3[0] + nums4[1] = 1 + (-2) + (-1) + 2 = 0
    //2. (1, 1, 0, 0) -> nums1[1] + nums2[1] + nums3[0] + nums4[0] = 2 + (-1) + (-1) + 0 = 0
    public class _454_4Sum_II
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0; j < nums4.Length; j++)
                {
                    int sum = nums3[i] + nums4[j];
                    if (dic.ContainsKey(sum))
                    {
                        dic[sum]++;
                    }
                    else
                    {
                        dic[sum] = 1;
                    }
                }
            }

            int answer = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    int result = 0 - nums1[i] - nums2[j];
                    if (dic.ContainsKey(result))
                    {
                        answer += dic[result];
                    }
                }
            }

            return answer;
        }
    }
}
