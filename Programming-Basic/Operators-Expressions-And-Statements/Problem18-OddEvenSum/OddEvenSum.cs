using System;

public class OddEvenSum
{
    public static void Main()
    {
        int countOfNumbersCollection = int.Parse(Console.ReadLine());

        int sumOfOddCollection = 0;
        int sumOfEvenCollection = 0;

        int lengthOfLoop = countOfNumbersCollection*2;
        for (int i = 1; i <= lengthOfLoop; i++)
        {
            int numbersOfCollection = int.Parse(Console.ReadLine());
            if (i%2 != 0)
            {
                sumOfOddCollection += numbersOfCollection;
            }
            else
            {
                sumOfEvenCollection += numbersOfCollection;
            }
        }

        if (sumOfOddCollection == sumOfEvenCollection)
        {
            Console.WriteLine("Yes, sum={0}", sumOfOddCollection);
        }
        else
        {
            int diff = Math.Abs(sumOfOddCollection - sumOfEvenCollection);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}

