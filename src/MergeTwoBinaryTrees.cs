namespace LeetCode.Problems
{
    internal sealed class MergeTwoBinaryTrees
    {
        public static TreeNode Run(TreeNode root1, TreeNode root2)
        {
            var result = Merge(root1, root2);
            return result;
        }

        private static TreeNode Merge(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
            {
                return root2;
            }

            if (root2 == null)
            {
                return root1;
            }

            var val = root1.val + root2.val;
            var left = Merge(root1.left, root2.left);
            var right = Merge(root1.right, root2.right);
            var node = new TreeNode(val, left, right);

            return node;
        }

        internal sealed class TreeNode
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
}