using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: haystack = "mississippi", needle = "issip"
    //Output: 4
    //Explanation: "sad" occurs at index 0 and 6.
    //The first occurrence is at index 0, so we return 0.
    public class _28_Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public int StrStr(string haystack, string needle)
        {
            int index = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[index])
                {
                    index++;
                    if (needle.Length == index)
                    {
                        return i + 1 - needle.Length;
                    }
                }
                else
                {
                    i = i - index;
                    index = 0;
                }
            }

            return -1;
        }
    }
}
