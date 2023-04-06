using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: numRows = 5
    //Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
    public class _118_Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> lists = new List<IList<int>>();
            if (numRows <= 0) { return lists; }
            lists.Add(new List<int>(1) { 1 });
            if (numRows == 1) { return lists; }
            lists.Add(new List<int>(2) { 1, 1 });
            if (numRows == 2) { return lists; }

            for (int i = 2; i < numRows; i++)
            {
                var list = new List<int>(i + 1);
                list.Add(1);
                for (int j = 1; j < i; j++)
                {
                    list.Add(lists[i - 1][j - 1] + lists[i - 1][j]);
                }
                list.Add(1);
                lists.Add(list);
            }

            return lists;
        }
    }
}
