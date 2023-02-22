using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _173_Binary_Search_Tree_Iterator
    {
        public class BSTIterator
        {
            private int _index = 0;
            private List<int> _list = new();
            public BSTIterator(TreeNode root)
            {
                InorderTraversal(root);
            }

            public int Next()
            {
                return _list[_index++];
            }

            public bool HasNext()
            {
                return _index <= _list.Count - 1;
            }

            private void InorderTraversal(TreeNode root)
            {
                if(root == null) { return; }
                InorderTraversal(root.left);
                _list.Add(root.val);
                InorderTraversal(root.right);
            }
        }


    }
}
