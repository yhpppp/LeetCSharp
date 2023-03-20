using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{

    //Input: candidates = [2,3,6,7], target = 7
    //Output: [[2,2,3],[7]]
    //Explanation:
    //2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
    //7 is a candidate, and 7 = 7.
    //These are the only two combinations.
    public class _39_Combination_Sum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            CombinationSumRecursion(candidates, target, 0);
            return list;
        }

        List<IList<int>> list = new List<IList<int>>();
        List<int> subList = new();
        int sum = 0;

        private void CombinationSumRecursion(int[] condidates, int target, int start)
        {
            if (sum > target)
            {
                return;
            }

            if (sum == target)
            {
                list.Add(new List<int>(subList));
                return;
            }

            for (int i = start; i < condidates.Length; i++)
            {
                subList.Add(condidates[i]);
                sum += condidates[i];
                CombinationSumRecursion(condidates, target, i);
                subList.RemoveAt(subList.Count - 1);
                sum -= condidates[i];
            }
        }
    }
}
