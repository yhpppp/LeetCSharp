using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _383_Ransom_Note
    {
        //Input: ransomNote = "a", magazine = "b"
        //Output: false
        //Input: ransomNote = "aab", magazine = "baa"
        //Output: true
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var item in magazine)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            foreach (var item in ransomNote)
            {
                if (dic.ContainsKey(item) && dic[item] > 0)
                {
                    dic[item]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
