using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _144_Binary_Tree_Preorder_Traversal
    {
        List<int> list = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null) { return list; }
            list.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
            return list;
        }

        public IList<int> PreorderTraversal2(TreeNode root)
        {
            List<int> list = new List<int>();
            if(root == null) { return list; }
            Stack<Command> stack = new Stack<Command>();
            stack.Push(new Command("go", root));
            while (stack.Count > 0)
            {
                var command = stack.Pop();
                if (command.name.Equals("do"))
                {
                    list.Add(command.node.val);
                }
                else
                {
                    if (command.node.right != null)
                    {
                        stack.Push(new Command("go", command.node.right));
                    }
                    if (command.node.left != null)
                    {
                        stack.Push(new Command("go", command.node.left));
                    }
                    stack.Push(new Command("do", command.node));
                }

            }
            return list;
        }
        class Command
        {
            public string name; // go do
            public TreeNode node;

            public Command(string name, TreeNode node)
            {
                this.name = name;
                this.node = node;
            }
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
