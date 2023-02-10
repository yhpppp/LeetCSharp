using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: head = [1,2,3,4]
    //Output: [1,4,2,3]
    public class _143_Reorder_List
    {
        public void ReorderList(ListNode head)
        {
            List<ListNode> list = new List<ListNode>();

            ListNode cur = head;
            while (cur != null)
            {
                list.Add(cur);
                cur = cur.next;
            }

            int headIndex = 0;
            int tailIndex = list.Count - 1;

            while (headIndex < tailIndex)
            {
                list[headIndex].next = list[tailIndex];
                headIndex++;
                if (headIndex == tailIndex)
                {
                    break;
                }
                list[tailIndex].next = list[headIndex];
                tailIndex--;
            }

            list[headIndex].next = null;
        }
    }
}
