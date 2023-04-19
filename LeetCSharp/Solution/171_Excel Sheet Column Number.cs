using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _171_Excel_Sheet_Column_Number
    {
        public int TitleToNumber(string columnTitle)
        {
            int num = 0;
            foreach (char ch in columnTitle)
            {
                num *= 26;
                num += ch - 'A' + 1;
            }
            return num;
        }
    }
}
