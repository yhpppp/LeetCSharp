using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [1,2,3,4,5,6]
    //Output: true
    //Explanation: Every level before the last is full(ie.levels with node-values { 1}
    //and {2, 3}), and all nodes in the last level ({4, 5, 6}) are as far left as possible.
    public class _958_Check_Completeness_of_a_Binary_Tree
    {
        public bool IsCompleteTree(TreeNode root)
        {
            bool hasEmptyNode = false;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node == null)
                    {
                        hasEmptyNode = true;
                        continue;
                    }
                    else
                    {
                        if (hasEmptyNode) { return false; }
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }

                }
            }
            return true;
        }
    }
}
