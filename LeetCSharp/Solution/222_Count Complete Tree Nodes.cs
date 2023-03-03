using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [1,2,3,4,5,6]
    //Output: 6
    public class _222_Count_Complete_Tree_Nodes
    {
        public int CountNodes(TreeNode root)
        {
            int count = 0;
            if (root == null) { return count; }

            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(root);
            while (treeNodes.Count > 0)
            {
                int size = treeNodes.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = treeNodes.Dequeue();
                    count++;
                    if (node.left != null)
                    {
                        treeNodes.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        treeNodes.Enqueue(node.right);
                    }
                }
            }

            return count;
        }
    }
}
