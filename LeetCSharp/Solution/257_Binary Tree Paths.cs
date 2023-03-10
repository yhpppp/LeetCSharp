using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _257_Binary_Tree_Paths
    {
        //Input: root = [1,2,3,null,5]
        //Output: ["1->2->5","1->3"]
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();
            if (root == null)
            {
                return paths;
            }

            Queue<string> pathsQueue = new Queue<string>();
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(root);
            pathsQueue.Enqueue(root.val.ToString());
            while (treeNodes.Count > 0)
            {
                var node = treeNodes.Dequeue();
                var path = pathsQueue.Dequeue();

                if (node.left == null && node.right == null)
                {
                    paths.Add(path);
                }

                if (node.left != null)
                {
                    treeNodes.Enqueue(node.left);

                    StringBuilder sb = new(path);
                    sb.Append("->").Append(node.left.val);
                    pathsQueue.Enqueue(sb.ToString());
                }

                if (node.right != null)
                {
                    treeNodes.Enqueue(node.right);

                    StringBuilder sb = new(path);
                    sb.Append("->").Append(node.right.val);
                    pathsQueue.Enqueue(sb.ToString());
                }
            }

            return paths;
        }
    }
}
