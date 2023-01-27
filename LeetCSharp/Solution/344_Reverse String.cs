using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    //Input: s = ["h","e","l","l","o"]
    //Output: ["o","l","l","e","h"]
    public class _344_Reverse_String
    {
        public void ReverseString(char[] s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                char temp = s[l];
                s[l] = s[r];
                s[r] = temp;

                l++;
                r--;
            }
        }
    }
}
