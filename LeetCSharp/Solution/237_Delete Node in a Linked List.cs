using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [4,5,1,9], node = 5
    //Output: [4,1,9]
    //Explanation: You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.
    public class _237_Delete_Node_in_a_Linked_List
    {
        public void DeleteNode(ListNode node)
        {
            ListNode nextNode = node.next;
            node.val = nextNode.val;
            node.next = nextNode.next;
        }
    }
}
