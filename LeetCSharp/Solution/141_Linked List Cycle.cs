using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [3,2,0,-4], pos = 1
    //Output: true
    //Explanation: There is a cycle in the linked list, where the tail connects to the 1st node(0-indexed).
    public class _141_Linked_List_Cycle
    {
        public bool HasCycle1(ListNode head)
        {
            ListNode node = head;
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (node != null)
            {
                if (!set.Add(node))
                {
                    return true;
                }
                node = node.next;
            }
            return false;
        }

        public bool HasCycle2(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow) { return true; }
            }
            return false;
        }
    }
}
