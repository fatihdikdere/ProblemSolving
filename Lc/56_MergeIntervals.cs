namespace Lc;
public class _56_MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length < 2)
        {
            return intervals;
        }

        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        var currentInterval = intervals[0];
        var result = new List<int[]>
        {
            currentInterval
        };

        foreach (var interval in intervals)
        {
            var currentEnd = currentInterval[1];
            var nextStart = interval[0];
            var nextEnd = interval[1];

            if (currentEnd >= nextStart)
            {
                currentInterval[1] = Math.Max(currentEnd, nextEnd);
            }
            else
            {
                currentInterval = interval;

                result.Add(currentInterval);
            }
        }

        return result.ToArray();
    }
}
