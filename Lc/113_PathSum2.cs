namespace Lc;
public class _113_PathSum2
{
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        var result = new List<IList<int>>();
        var currentPath = new List<int>();

        Dfs(root, targetSum, currentPath, result);

        return result;
    }
    private void Dfs(TreeNode node, int remainingSum, List<int> currentPath, List<IList<int>> paths)
    {
        if (node is null)
        {
            return;
        }

        currentPath.Add(node.val);

        if (node.left is null && node.right is null && remainingSum == node.val)
        {
            paths.Add(new List<int>(currentPath));
        }
        else
        {
            Dfs(node.left, remainingSum - node.val, currentPath, paths);
            Dfs(node.right, remainingSum - node.val, currentPath, paths);
        }

        currentPath.RemoveAt(currentPath.Count - 1);
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
