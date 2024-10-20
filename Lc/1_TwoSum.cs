namespace Lc;
public class _1_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var temp = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (temp.TryGetValue(diff, out int value))
            {
                return [value, i];
            }

            temp[nums[i]] = i;
        }

        return [];
    }
}
