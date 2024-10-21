namespace Lc;
public class _202_HappyNumber
{
    public bool IsHappy(int n)
    {
        var visit = new HashSet<int>();

        while (!visit.Contains(n))
        {
            visit.Add(n);

            n = GetSumOfSquares(n);

            if (n == 1)
            {
                return true;
            }
        }

        return false;
    }
    private int GetSumOfSquares(int n)
    {
        var result = 0;

        while (n > 0)
        {
            var digit = n % 10;
            result += digit * digit;
            n /= 10;
        }

        return result;
    }
}
