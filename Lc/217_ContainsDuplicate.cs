namespace Lc;
public class _217_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        var numsHash = new HashSet<int>();

        foreach (var num in nums)
        {
            if (numsHash.Contains(num))
            {
                return true;
            }

            numsHash.Add(num);
        }

        return false;
    }
}
