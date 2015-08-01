using System;
using System.Linq;

public class SumOfElements
{
    public static void Main()
    {
        long[] inputNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long avarageSum = inputNumbers.Max();
        long sum = 0;
        bool isFirstMaxNumber = true;
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            if (inputNumbers[i] == avarageSum && isFirstMaxNumber)
            {
                inputNumbers[i] = 0;
                isFirstMaxNumber = false;
            }

            sum += inputNumbers[i];
        }

        if (avarageSum == sum)
        {
            Console.WriteLine("Yes, sum={0}", avarageSum);
        }

        else
        {
            long diff = Math.Abs(sum - avarageSum);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}

