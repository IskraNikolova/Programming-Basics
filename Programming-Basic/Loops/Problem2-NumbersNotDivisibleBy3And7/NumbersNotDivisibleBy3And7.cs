using System;

public class NumbersNotDivisibleBy3And7
{
    public static void Main()
    {
        int lengthForLoop = int.Parse(Console.ReadLine());

        for (int number = 0; number < lengthForLoop; number++)
        {
            if (number != 3 && number != 7)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}

