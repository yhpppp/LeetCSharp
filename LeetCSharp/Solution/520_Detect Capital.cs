using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _520_Detect_Capital
    {
        //Input: word = "USA"
        //Output: true
        //Input: word = "FlaG"
        //Output: false
        //Input: word = "g"
        //Output: true
        public bool DetectCapitalUse(string word)
        {
            int upper = 0;
            foreach (char c in word)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    upper++;
                }
            }
            if (upper == 1 && word[0] <= 'Z')
            {
                return true;
            }
            return upper == word.Length || upper == 0;
        }
    }
}
