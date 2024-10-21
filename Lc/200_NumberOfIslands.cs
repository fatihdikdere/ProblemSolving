namespace Lc;
public class _200_NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        if (grid is null || grid.Length == 0)
        {
            return 0;
        }

        var result = 0;
        var rows = grid.Length;
        var cols = grid[0].Length;

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1')
                {
                    result++;

                    Dfs(grid, i, j);
                }
            }
        }

        return result;
    }
    private void Dfs(char[][] grid, int row, int col)
    {
        if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] == '0')
        {
            return;
        }

        grid[row][col] = '0';

        Dfs(grid, row - 1, col);
        Dfs(grid, row + 1, col);
        Dfs(grid, row, col - 1);
        Dfs(grid, row, col + 1);
    }
}
