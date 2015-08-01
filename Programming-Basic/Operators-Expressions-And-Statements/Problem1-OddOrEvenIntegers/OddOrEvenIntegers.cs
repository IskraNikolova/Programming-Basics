using System;

public class OddOrEvenIntegers
{
    /// <summary>
    /// Write an expression that checks if given integer is odd or even.
    /// </summary>
    public static void Main()
    {
        bool isOdd = true;

        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber % 2 == 0)
        {
            isOdd = false;
        }

        Console.WriteLine(isOdd);

    }
}

