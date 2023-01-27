using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    //Input: s = "A man, a plan, a canal: Panama"
    //Output: true
    //Explanation: "amanaplanacanalpanama" is a palindrome.
    public class _125_Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                while (l < r && !char.IsLetterOrDigit(s[l]))
                {
                    l++;

                }
                while (l < r && !char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                
                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
    }
}
