using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
    //Output: true
    //Explanation: The root-to-leaf path with the target sum is shown.
    public class _112_Path_Sum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) { return false; }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            Queue<int> count = new Queue<int>();
            count.Enqueue(root.val);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                var sum = count.Dequeue();
                // get to leaf node
                if (node.left == null && node.right == null)
                {
                    if (sum == targetSum)
                    {
                        return true;
                    }
                }
                else
                {
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        count.Enqueue(sum + node.left.val);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        count.Enqueue(sum + node.right.val);
                    }
                }
            }

            return false;
        }
    }
}
