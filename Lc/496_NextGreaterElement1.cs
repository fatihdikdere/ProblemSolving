namespace Lc;
public class _496_NextGreaterElement1
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var nextGreaterMap = new Dictionary<int, int>();
        var stack = new Stack<int>();

        foreach (var num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
            {
                nextGreaterMap[stack.Pop()] = num;
            }

            stack.Push(num);
        }

        while (stack.Count > 0)
        {
            nextGreaterMap[stack.Pop()] = -1;
        }

        var result = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = nextGreaterMap[nums1[i]];
        }

        return result;
    }
}
