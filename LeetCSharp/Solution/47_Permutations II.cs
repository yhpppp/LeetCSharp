using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [1,1,2]
    //Output:
    //[[1,1,2],
    // [1,2,1],
    // [2,1,1]]
    public class _47_Permutations_II
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            used = new bool[nums.Length];
            System.Array.Sort(nums);
            PermuteUniqueRecursion(nums);
            return list;

        }
        List<IList<int>> list = new();
        List<int> subList = new();
        bool[] used;
        private void PermuteUniqueRecursion(int[] nums)
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

                if (i > 0 && nums[i] == nums[i - 1] && used[i - 1] == false)
                {
                    continue;
                }

                subList.Add(nums[i]);
                used[i] = true;
                PermuteUniqueRecursion(nums);
                subList.RemoveAt(subList.Count - 1);
                used[i] = false;
            }
        }
    }
}
