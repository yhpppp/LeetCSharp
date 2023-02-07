using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,2,3,4,5], left = 2, right = 4
    //Output: [1,4,3,2,5]
    public class _92_Reverse_Linked_List_II
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == right) { return head; }

            ListNode dummyHead = new ListNode(-1, head);

            ListNode firstLastNode = dummyHead;
            for (int i = 0; i < left - 1; i++)
            {
                firstLastNode = firstLastNode.next;
            }
            ListNode secondLastNode = dummyHead;
            for (int i = 0; i < right; i++)
            {
                secondLastNode = secondLastNode.next;
            }

            ListNode secondHeadNode = firstLastNode.next;
            firstLastNode.next = null;
            ListNode thirdHeadNode = secondLastNode.next;
            secondLastNode.next = null;


            ListNode pre = null;
            ListNode cur = secondHeadNode;

            while (cur != null)
            {
                var next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }


            ListNode oldSecondHeadNode = secondHeadNode;
            secondHeadNode = secondLastNode;
            secondLastNode = oldSecondHeadNode;

            firstLastNode.next = secondHeadNode;
            secondLastNode.next = thirdHeadNode;


            return dummyHead.next;
        }
    }
}
