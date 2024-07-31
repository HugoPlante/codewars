using System;
using System.Text;

public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        StringBuilder result = new("");

        int start = args[0];
        int end = args[0];

        for (int i = 1; i < args.Length; i++)
        {
            if (args[i] == end + 1)
            {
                end = args[i];
            }
            else
            {
                AppendRange(result, start, end);
                start = args[i];
                end = args[i];
            }
        }
        AppendRange(result, start, end);

        return result.ToString();
    }

    private static void AppendRange(StringBuilder result, int start, int end)
    {
        if (result.Length > 0)
        {
            result.Append(',');
        }

        if (start == end)
        {
            // no consecutive numbers
            result.Append(start);
        }
        else if (start + 1 == end)
        {
            // exactly 2 consecutive numbers
            result.Append(start).Append(',').Append(end);
        }
        else
        {
            //more than 2 consecutive numbers
            result.Append(start).Append('-').Append(end);
        }
    }

    static void Main()
    {
        Console.WriteLine(Extract([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]));
    }
}