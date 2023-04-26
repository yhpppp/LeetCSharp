using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: columnNumber = 28
    //Output: "AB"
    public class _168_Excel_Sheet_Column_Title
    {
        public string ConvertToTitle(int columnNumber)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();
            while (columnNumber > 0)
            {
                columnNumber--;

                int d = columnNumber % 26;
                sb.Insert(0, chars[d]);

                columnNumber /= 26;
            }
            return sb.ToString();
        }
    }
}
