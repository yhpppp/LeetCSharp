using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [-10,-3,0,5,9]
    //Output: [0,-3,9,-10,null,5]
    //Explanation: [0,-10,5,null,-3,null,9] is also accepted:
    public class _108_Convert_Sorted_Array_to_Binary_Search_Tree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length);
        }

        private TreeNode SortedArrayToBST(int[] nums, int l, int r)
        {
            if (l >= r) { return null; }
            var midIndex = (r - l) / 2 + l;
            var node = new TreeNode(nums[midIndex]);
            node.left = SortedArrayToBST(nums, l, midIndex);
            node.right = SortedArrayToBST(nums, midIndex + 1, r);
            return node;
        }
    }
}
