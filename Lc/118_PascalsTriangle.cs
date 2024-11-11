namespace Lc;
public class _118_PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            var currentRow = new int[i + 1];
            currentRow[0] = 1;
            currentRow[i] = 1;

            for (int j = 1; j < i; j++)
            {
                currentRow[j] = result[i - 1][j - 1] + result[i - 1][j];
            }

            result.Add(currentRow);
        }

        return result;
    }
}
