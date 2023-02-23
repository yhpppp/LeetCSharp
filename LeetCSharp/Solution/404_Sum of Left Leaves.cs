using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [3,9,20,null,null,15,7]
    //Output: 24
    //Explanation: There are two left leaves in the binary tree, with values 9 and 15 respectively.
    public class _404_Sum_of_Left_Leaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            Stack<Command> stacks = new();
            stacks.Push(new Command("GO", root));
            while (stacks.Count > 0)
            {
                Command command = stacks.Pop();
                if (command.Action.Equals("GO"))
                {
                    if (command.Node.right != null)
                    {
                        stacks.Push(new Command("GO", command.Node.right));
                    }
                    if (command.Node.left != null)
                    {
                        stacks.Push(new Command("GO", command.Node.left));
                    }
                    stacks.Push(new Command("DO", command.Node));
                }
                else
                {
                    if (IsLeftLeafNode(command.Node))
                    {
                        sum += command.Node.left.val;
                    }
                }
            }
            return sum;
        }
        private bool IsLeftLeafNode(TreeNode node)
        {
            return node.left != null && node.left.left == null && node.left.right == null;
        }
        class Command
        {
            public string Action { get; private set; } // GO DO
            public TreeNode Node { get; private set; }

            public Command(string action, TreeNode node)
            {
                Action = action;
                Node = node;
            }
        }
    }
}
