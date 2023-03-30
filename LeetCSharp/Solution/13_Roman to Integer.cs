using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: s = "LVIII"
    //Output: 58
    //Explanation: L = 50, V= 5, III = 3.
    public class _13_Roman_to_Integer
    {
        //"MCMXCIV"
        public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i > 0 && Mapping(s[i]) > Mapping(s[i - 1]))
                {
                    result += Mapping(s[i]) - Mapping(s[i - 1]) - Mapping(s[i - 1]);
                }
                else
                {
                    result += Mapping(s[i]);
                }
            }
            return result;
        }

        private int Mapping(char ch)
        {
            switch (ch)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
