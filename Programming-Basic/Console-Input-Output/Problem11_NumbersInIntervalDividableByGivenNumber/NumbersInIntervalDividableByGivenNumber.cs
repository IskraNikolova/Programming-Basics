using System;
public class NumbersInIntervalDividableByGivenNumber
{
    /// <summary>
    /// Write a program that reads two positive integer numbers and prints how many numbers p exist
    ///  between them such that the reminder of the division by 5 is 0.
    /// </summary>
    public static void Main()
    {
        const int divider = 5;

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int countOfNumDividable = 0;
        for (int number = firstNumber; number <= secondNumber; number++)
        {
            if (number%divider == 0)
            {
                countOfNumDividable++;
            }
        }

        Console.WriteLine(countOfNumDividable);
    }
}

