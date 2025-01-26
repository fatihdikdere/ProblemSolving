namespace Lc;
public class _268_MissingNumber
{
    public int MissingNumber(int[] nums)
    {
        var result = 0;
        var resultExpected = (nums.Length * (nums.Length + 1)) / 2;

        for (var i = 0; i < nums.Length; i++)
        {
            result += nums[i];
        }

        return resultExpected - result;
    }
}
