using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,2,6,3,4,5,6], val = 6
    //Output: [1,2,3,4,5]
    public class _203_Remove_Linked_List_Elements
    {
        public ListNode RemoveElements1(ListNode head, int val)
        {
            while (head != null && head.val == val)
            {
                head = head.next;
            }
            ListNode node = head;
            while (node != null)
            {
                if (node.next != null && node.next.val == val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }

            return head;
        }

        public ListNode RemoveElements2(ListNode head, int val)
        {
            ListNode dummyHead = new ListNode(-1, head);

            ListNode node = dummyHead;

            while (node != null)
            {
                if (node.next != null && node.next.val == val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }

            return dummyHead.next;
        }
    }
}
