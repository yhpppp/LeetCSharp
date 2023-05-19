using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _205_Isomorphic_Strings
    {
        //Input: s = "paper", t = "title"
        //Output: true
        //Input: s = "badc", t = "baba"
        //Output: false
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, char> sDict = new Dictionary<char, char>();
            Dictionary<char, char> tDict = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];

                if (sDict.ContainsKey(sChar))
                {
                    if (sDict[sChar] != tChar)
                    {
                        return false;
                    }
                }
                else if (tDict.ContainsKey(tChar))
                {
                    if (tDict[tChar] != sChar)
                    {
                        return false;
                    }
                }
                else
                {
                    sDict[sChar] = tChar;
                    tDict[tChar] = sChar;
                }
            }

            return true;
        }
    }
}
