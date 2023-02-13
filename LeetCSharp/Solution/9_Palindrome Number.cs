using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: x = 121
    //Output: true
    //Explanation: 121 reads as 121 from left to right and from right to left.
    public class _9_Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            string temp = x.ToString();
            int i = 0;
            int j = temp.Length - 1;

            while (i < j)
            {
                if (temp[i] != temp[j])
                {
                    return false;
                }
                i++;
                j--;

            }

            return true;
        }
    }
}
