using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: rowIndex = 3
    //Output: [1,3,3,1]
    public class _119_Pascal_s_Triangle_II
    {
        public IList<int> GetRow(int rowIndex)
        {
            var arr = new int[rowIndex + 1];
            arr[0] = 1;
            if (rowIndex == 0)
            {
                return arr;
            }

            for (int i = 1; i <= rowIndex; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    arr[j] = arr[j - 1] + arr[j];
                }
            }
            return arr;
        }
    }
}
