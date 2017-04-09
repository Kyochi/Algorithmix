using System.Collections.Generic;

namespace Algorithmix.Tree
{
    class BTPreOrder
    {
        internal class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int v)
            {
                val = v;
            }
        }
        /*
         * Given a BT, return the preorder traversal of its nodes’ values. (without recursion)
         */
        public List<int> preorderTraversal(TreeNode A)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            if (A == null) return res;

            s.Push(A);
            while (s.Count != 0)
            {
                TreeNode cur = s.Pop();
                if (cur != null)
                {
                    res.Add(cur.val);
                    s.Push(cur.right);
                    s.Push(cur.left);
                }
            }
            return res;
        }
    }
}
