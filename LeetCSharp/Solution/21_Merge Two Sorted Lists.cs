using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    // Input: list1 = [1,2,4], list2 = [1,3,4]
    // Output: [1,1,2,3,4,4]
    public class _21_Merge_Two_Sorted_Lists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummyHeader = new ListNode(-1, null);

            ListNode cur = dummyHeader;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    cur.next = list1;
                    list1 = list1.next;
                    cur = cur.next;
                }
                else
                {
                    cur.next = list2;
                    list2 = list2.next;
                    cur = cur.next;
                }
            }

            cur.next = list1 != null ? list1 : list2;
            return dummyHeader.next;
        }
    }
}
