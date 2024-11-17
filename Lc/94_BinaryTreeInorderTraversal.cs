namespace Lc;
public class _94_BinaryTreeInorderTraversal
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return [];
        }

        var result = new List<int>();

        result.AddRange(InorderTraversal(root.left));
        result.Add(root.val);
        result.AddRange(InorderTraversal(root.right));

        return result;
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
