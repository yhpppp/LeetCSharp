using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [3,9,20,null,null,15,7]
    //Output: 2
    public class _111_Minimum_Depth_of_Binary_Tree
    {
        public int MinDepth(TreeNode root)
        {
            int depth = 0;
            if (root == null)
            {
                return depth;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                depth++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left == null && node.right == null)
                    {
                        return depth;
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            return depth;
        }
    }
}
