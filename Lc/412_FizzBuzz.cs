namespace Lc;
public class _412_FizzBuzz
{
    public IList<string> FizzBuzz(int n)
    {
        var result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
            {
                result.Add("FizzBuzz");

                continue;
            }

            if (i % 5 == 0)
            {
                result.Add("Buzz");

                continue;
            }

            if (i % 3 == 0)
            {
                result.Add("Fizz");

                continue;
            }

            result.Add(i.ToString());
        }

        return result;
    }
}
