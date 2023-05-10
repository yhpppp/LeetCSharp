using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _387_First_Unique_Character_in_a_String
    {
        //Input: s = "loveleetcode"
        //Output: 2
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dic[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
