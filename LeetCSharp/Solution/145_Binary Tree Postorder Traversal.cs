using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [1,null,2,3]
    //Output: [3,2,1]
    public class _145_Binary_Tree_Postorder_Traversal
    {
        List<int> list = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) { return list; }

            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            list.Add(root.val);

            return list;
        }

        public IList<int> PostorderTraversal2(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) { return list; }

            Stack<Command> stacks = new();
            stacks.Push(new Command("GO", root));

            while (stacks.Count > 0)
            {
                var command = stacks.Pop();
                if (command.name.Equals("DO"))
                {
                    list.Add(command.node.val);
                }
                else
                {
                    stacks.Push(new Command("DO", command.node));
                    if(command.node.right != null)
                    {
                        stacks.Push(new Command("GO", command.node.right));
                    }

                    if(command.node.left != null)
                    {
                        stacks.Push(new Command("GO", command.node.left));
                    }
                }
            }
        }
        class Command
        {
            public string name; // GO DO
            public TreeNode node;

            public Command(string name, TreeNode node)
            {
                this.name = name;
                this.node = node;
            }
        }
    }
}
