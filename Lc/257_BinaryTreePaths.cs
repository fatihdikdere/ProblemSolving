namespace Lc;
public class _257_BinaryTreePaths
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var result = new List<string>();

        if (root != null)
        {
            Dfs(root, string.Empty, result);
        }

        return result;
    }
    private void Dfs(TreeNode node, string path, IList<string> paths)
    {
        if (node.left is null && node.right is null)
        {
            paths.Add($"{path}{node.val}");

            return;
        }

        path += $"{node.val}->";


        if (node.left is not null)
        {
            Dfs(node.left, path, paths);
        }

        if (node.right is not null)
        {
            Dfs(node.right, path, paths);
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