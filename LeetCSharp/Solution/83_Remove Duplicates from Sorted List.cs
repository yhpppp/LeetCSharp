using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,1,2,3,3]
    //Output: [1,2,3]
    public class _83_Remove_Duplicates_from_Sorted_List
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) { return null; }
            ListNode cur = head;
            while (cur.next != null)
            {
                if (cur.val == cur.next.val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }
            return head;
        }
    }
}
