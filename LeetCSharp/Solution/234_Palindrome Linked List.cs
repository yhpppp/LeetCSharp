using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,2,2,1]
    //Output: true
    public class _234_Palindrome_Linked_List
    {
        public bool IsPalindrome(ListNode head)
        {
            List<int> list = new List<int>();

            ListNode cur = head;
            while (cur != null)
            {
                list.Add(cur.val);
                cur = cur.next;
            }

            int headIndex = 0;
            int lastIndex = list.Count - 1;

            while (headIndex < lastIndex)
            {
                if (list[headIndex] != list[lastIndex])
                {
                    return false;
                }

                headIndex++;
                lastIndex--;
            }

            return true;
        }
    }
}
