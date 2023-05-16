using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _389_Find_the_Difference
    {
        //Input: s = "abcd", t = "abcde"
        //Output: "e"
        //Explanation: 'e' is the letter that was added.
        public char FindTheDifference(string s, string t)
        {
            int letter = 0;
            foreach (var item in t)
            {
                letter += item;
            }
            foreach (var item in s)
            {
                letter -= item;
            }
            return (char)letter;
        }

        public char FindTheDifference2(string s, string t)
        {
            List<char> list = new List<char>(t);
            foreach (var item in s)
            {
                list.Remove(item);
            }
            return list[0];
        }

    }
}
