using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _230_Kth_Smallest_Element_in_a_BST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            Stack<Command> stacks = new Stack<Command>();
            stacks.Push(new Command(root, "GO"));

            int index = 1;

            while (stacks.Count > 0)
            {
                var command = stacks.Pop();

                if (command.Name.Equals("GO"))
                {
                    if (command.Node.right != null)
                    {
                        stacks.Push(new Command(command.Node.right, "GO"));
                    }

                    stacks.Push(new Command(command.Node, "DO"));

                    if (command.Node.left != null)
                    {
                        stacks.Push(new Command(command.Node.left, "GO"));
                    }
                }
                else
                {
                    if (index == k)
                    {
                        return command.Node.val;
                    }
                    index++;
                }
            }
            return -1;
        }
        class Command
        {
            public TreeNode Node { get; private set; }
            public string Name { get; private set; }

            public Command(TreeNode node, string name)
            {
                this.Node = node;
                this.Name = name;
            }
        }
    }
}
