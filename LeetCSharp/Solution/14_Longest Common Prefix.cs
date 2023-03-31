using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: strs = ["flower","flow","flight"]
    //Output: "fl"
    public class _14_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string firstWord = strs[0];
            bool isSame = true;
            int index;
            for (index = 0; index < firstWord.Length; index++)
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    string word = strs[i];
                    //["ab", "a"]
                    if (index > word.Length - 1 || word[index] != firstWord[index])
                    {
                        isSame = false;
                        break;
                    }
                }

                if (!isSame)
                {
                    break;
                }
            }
            return firstWord.Substring(0, index);
        }
    }
}
