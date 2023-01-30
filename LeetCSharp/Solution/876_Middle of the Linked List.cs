using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,2,3,4,5]
    //Output: [3,4,5]
    //Explanation: The middle node of the list is node 3.
    public class _876_Middle_of_the_Linked_List
    {

        public ListNode MiddleNode1(ListNode head)
        {
            int nodeLength = 0;
            for (ListNode i = head; i != null; i = i.next)
            {
                nodeLength++;
            }
            int middleNum = nodeLength / 2;
            for (int i = 0; i < middleNum; i++)
            {
                head = head.next;
            }
            return head;
        }

        public ListNode MiddleNode2(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }
    }

    /**
 * Definition for singly-linked list.
 */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
