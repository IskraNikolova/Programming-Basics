using System;

public class HalfSum
{
    public static void Main()
    {
        int countOfNumber = int.Parse(Console.ReadLine());

        int firstSum = 0;
        for (int index = 0; index < countOfNumber; index++)
        {
            int addend = int.Parse(Console.ReadLine());
            firstSum += addend;
        }

        int secondSum = 0;
        for (int index = 0; index < countOfNumber; index++)
        {
            int addend = int.Parse(Console.ReadLine());
            secondSum += addend;
        }

        int rest = Math.Abs(firstSum - secondSum);
        if (rest == 0)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", rest);
        }

    }
}

