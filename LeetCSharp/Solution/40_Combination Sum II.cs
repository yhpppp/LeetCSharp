using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //    Input: candidates = [2,5,2,1,2], target = 5
    //Output: 
    //[
    //[1,2,2],
    //[5]
    //]
    public class _40_Combination_Sum_II
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            System.Array.Sort(candidates);
            CombinationSum2Recursion(candidates, target, 0);
            return res;
        }
        List<IList<int>> res = new();
        List<int> list = new();
        int sum = 0;

        private void CombinationSum2Recursion(int[] candidates, int target, int start)
        {
            if (sum == target)
            {
                res.Add(new List<int>(list));
                return;
            }
            if (sum > target)
            {
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                list.Add(candidates[i]);
                sum += candidates[i];

                CombinationSum2Recursion(candidates, target, i + 1);

                list.RemoveAt(list.Count - 1);
                sum -= candidates[i];
            }
        }
    }
}
