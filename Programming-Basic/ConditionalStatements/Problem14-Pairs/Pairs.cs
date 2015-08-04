using System;
using System.Collections.Generic;
using System.Linq;

public class Pairs
{
    public static void Main()
    {
        int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int sum1 = 0;
        int sum2 = 0;
        int maxCountEqualsSum = inputNumbers.Length/2;
        int countEqualsSum = 1;

        List<int> difference = new List<int>();
        for (int i = 0; i < inputNumbers.Length - 1; i = i + 2)
        {
            sum1 = inputNumbers[i] + inputNumbers[i + 1];
            difference.Add(sum1);

            if (sum1.Equals(sum2))
            {
                countEqualsSum++;
            }
            sum2 = sum1;
        }

        if (countEqualsSum.Equals(maxCountEqualsSum))
        {
            Console.WriteLine("Yes, value={0}", difference[0]);
        }
        else
        {
            int minSum = difference.Min();
            int maxSum = difference.Max();
            int maxDiff = maxSum - minSum;

            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}


