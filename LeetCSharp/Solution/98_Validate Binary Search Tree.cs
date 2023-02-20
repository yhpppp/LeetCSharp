using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: root = [2,1,3]
    //Output: true
    public class _98_Validate_Binary_Search_Tree
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return false;

            long val = long.MinValue;
            Stack<Command> stacks = new();
            stacks.Push(new Command("GO", root));

            while (stacks.Count > 0)
            {
                var command = stacks.Pop();
                if (command.Name.Equals("GO"))
                {
                    if (command.Node.right != null)
                    {
                        stacks.Push(new Command("GO", command.Node.right));
                    }

                    stacks.Push(new Command("DO", command.Node));

                    if (command.Node.left != null)
                    {
                        stacks.Push(new Command("GO", command.Node.left));
                    }
                }
                else
                {
                    if (val < command.Node.val)
                    {
                        val = command.Node.val;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        class Command
        {
            public string Name { get; private set; }
            public TreeNode Node { get; private set; }

            public Command(string name, TreeNode node)
            {
                Name = name;
                Node = node;
            }
        }
    }
}
