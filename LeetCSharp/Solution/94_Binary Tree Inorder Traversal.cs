using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [1,null,2,3]
    //Output: [1,3,2]
    public class _94_Binary_Tree_Inorder_Traversal
    {
        List<int> list = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return list;
            }

            InorderTraversal(root.left);
            list.Add(root.val);
            InorderTraversal(root.right);

            return list;
        }

        public IList<int> InorderTraversal2(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) { return list; }

            Stack<Command> stacks = new Stack<Command>();
            stacks.Push(new Command("GO", root));

            while (stacks.Count > 0)
            {
                Command command = stacks.Pop();
                if (command.name.Equals("DO"))
                {
                    list.Add(command.TreeNode.val);
                }
                else
                {
                    if (command.TreeNode.right != null)
                    {
                        stacks.Push(new Command("GO", command.TreeNode.right));
                    }

                    stacks.Push(new Command("DO", command.TreeNode));

                    if (command.TreeNode.left != null)
                    {
                        stacks.Push(new Command("GO", command.TreeNode.left));
                    }
                }
            }

            return list;
        }
        class Command
        {
            public string name; // DO GO
            public TreeNode TreeNode;

            public Command(string name, TreeNode treeNode)
            {
                this.name = name;
                TreeNode = treeNode;
            }
        }

    }
}
