using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [1,2,2]
    //Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
    public class _90_Subsets_II
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            System.Array.Sort(nums);
            SubsetsRecursion(nums, 0);
            return res;
        }

        List<IList<int>> res = new();
        List<int> list = new();
        private void SubsetsRecursion(int[] nums, int start)
        {
            res.Add(new List<int>(list));
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                {
                    continue;
                }
                list.Add(nums[i]);
                SubsetsRecursion(nums, i + 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
