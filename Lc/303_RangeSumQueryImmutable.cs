namespace Lc;
public class _303_RangeSumQueryImmutable
{
    private readonly List<int> prefixSum = [];
    public _303_RangeSumQueryImmutable(int[] nums)
    {
        var current = 0;

        foreach (var num in nums)
        {
            current += num;

            prefixSum.Add(current);
        }
    }
    public int SumRange(int left, int right)
    {
        var result = prefixSum[right] - (
            left > 0
                ? prefixSum[left - 1]
                : 0
        );

        return result;
    }
}
