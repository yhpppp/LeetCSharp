using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: n = 4, k = 2
    //Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
    //Explanation: There are 4 choose 2 = 6 total combinations.
    //Note that combinations are unordered, i.e., [1,2] and[2, 1] are considered to be the same combination.
    public class _77_Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            CombineRecursion(n, k, 1);
            return res;
        }

        List<IList<int>> res = new List<IList<int>>();
        List<int> list = new List<int>();

        private void CombineRecursion(int n, int k, int start)
        {
            if (k == list.Count)
            {
                res.Add(new List<int>(list));
            }

            for (int i = start; i <= n; i++)
            {
                list.Add(i);
                CombineRecursion(n, k, i + 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
