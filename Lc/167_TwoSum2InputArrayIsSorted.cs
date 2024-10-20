namespace Lc;
public class _167_TwoSum2InputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var currentSum = numbers[left] + numbers[right];

            if (currentSum == target)
            {
                return [left + 1, right + 1];
            }

            if (currentSum > target)
            {
                right -= 1;
                continue;
            }

            if (currentSum < target)
            {
                left += 1;
            }
        }

        return [];
    }
}
