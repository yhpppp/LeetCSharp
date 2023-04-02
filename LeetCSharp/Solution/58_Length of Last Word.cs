using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: s = "Hello World"
    //Output: 5
    //Explanation: The last word is "World" with length 5.
    public class _58_Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            int index = s.Length - 1;
            while (index >= 0 && s[index] == ' ')
            {
                index--;
            }
            int len = 0;
            while (index >= 0 && s[index] != ' ')
            {
                len++;
                index--;
            }
            return len;
        }
    }
}
