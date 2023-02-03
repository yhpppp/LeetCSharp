using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,2,3,3,3,4,4,5]
    //Output: [1,2,5]
    public class _82_Remove_Duplicates_from_Sorted_List_II
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dummyHead = new ListNode(-1, head);
            ListNode cur = dummyHead;
            while (cur.next != null && cur.next.next != null)
            {
                if (cur.next.val == cur.next.next.val)
                {
                    var tempVal = cur.next.val;
                    while (cur.next != null && cur.next.val == tempVal)
                    {
                        cur.next = cur.next.next;
                    }

                }
                else
                {
                    cur = cur.next;
                }
            }
            return dummyHead.next;
        }
    }
}
