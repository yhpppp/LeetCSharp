using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,2,3,4,5]
    //Output: [5,4,3,2,1]
    public class _206_Reverse_Linked_List
    {
        public ListNode ReverseList1(ListNode head)
        {
            if (head == null) { return null; }
            List<ListNode> list = new List<ListNode>();
            for (ListNode i = head; i != null; i = i.next)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    list[i].next = null;
                }
                else
                {
                    list[i].next = list[i - 1];
                }
            }

            return list[list.Count - 1];
        }

        public ListNode ReverseList2(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                var next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }
            return pre;
        }
    }
}
