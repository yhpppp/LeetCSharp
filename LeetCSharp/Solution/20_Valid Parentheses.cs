using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: s = "()[]{}"
    //Output: true
    public class _20_Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char peekValue = stack.Peek();
                    if (peekValue == '(' && c == ')' || peekValue == '{' && c == '}' || peekValue == '[' && c == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
