using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [1,2,2,3,4,4,3]
    //Output: true
    public class _101_Symmetric_Tree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root.left, root.right);
        }

        private bool IsMirror(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null && rightNode == null)
            {
                return true;
            }
            if (leftNode == null || rightNode == null)
            {
                return false;
            }
            if (leftNode.val != rightNode.val)
            {
                return false;
            }

            return IsMirror(leftNode.left, rightNode.right) && IsMirror(leftNode.right, rightNode.left);
        }
    }
}
