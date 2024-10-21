namespace Lc;
public class _643_MaximumAverageSubarray1
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var currentSum = nums.Take(k).Sum();
        var maxSum = currentSum;

        for (var i = k; i < nums.Length; i++)
        {
            currentSum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, currentSum);
        }

        var result = (double)maxSum / k;

        return result;
    }
}
