using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //    Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
    //Output: [[5,4,11,2],[5,8,4,5]]
    //Explanation: There are two paths whose sum equals targetSum:
    //5 + 4 + 11 + 2 = 22
    //5 + 8 + 4 + 5 = 22
    public class _113_Path_Sum_II
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> nodesQueue = new Queue<TreeNode>();
            nodesQueue.Enqueue(root);
            Queue<int> sumQueue = new Queue<int>();
            sumQueue.Enqueue(root.val);
            Queue<string> strQueue = new Queue<string>();
            strQueue.Enqueue(root.val.ToString());

            while (nodesQueue.Count > 0)
            {
                TreeNode node = nodesQueue.Dequeue();
                int sum = sumQueue.Dequeue();
                string str = strQueue.Dequeue();

                if (node.left == null && node.right == null)
                {
                    if (sum == targetSum)
                    {
                        var strArr = str.Split(',');
                        var intArr = System.Array.ConvertAll(strArr, int.Parse);
                        result.Add(intArr);
                    }
                }

                if (node.left != null)
                {
                    nodesQueue.Enqueue(node.left);

                    sumQueue.Enqueue(sum + node.left.val);

                    StringBuilder sb = new(str);
                    sb.Append(',').Append(node.left.val);
                    strQueue.Enqueue(sb.ToString());
                }

                if (node.right != null)
                {
                    nodesQueue.Enqueue(node.right);

                    sumQueue.Enqueue(sum + node.right.val);

                    StringBuilder sb = new(str);
                    sb.Append(',').Append(node.right.val);
                    strQueue.Enqueue(sb.ToString());
                }
            }

            return result;
        }
    }
}
