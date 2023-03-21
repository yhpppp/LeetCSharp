using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [1,2,3]
    //Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
    public class _46_Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            used = new bool[nums.Length];
            PermuteRecursion(nums);
            return list;
        }
        List<IList<int>> list = new List<IList<int>>();
        List<int> subList = new();
        bool[] used;
        private void PermuteRecursion(int[] nums)
        {
            if (nums.Length == subList.Count)
            {
                list.Add(new List<int>(subList));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }
                subList.Add(nums[i]);
                used[i] = true;
                PermuteRecursion(nums);
                subList.RemoveAt(subList.Count - 1);
                used[i] = false;
            }
        }
    }
}
