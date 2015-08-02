using System;

public class TheBiggestOf3Numbers
{
    /// <summary>
    /// Write a program that finds the biggest of three numbers
    /// </summary>
    public static void Main()
    {
        const int countOfNumbers = 3;

        double maxValue = 0;
        for (int i = 0; i < countOfNumbers; i++)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            if (inputNumber > maxValue)
            {
                maxValue = inputNumber;
            }
        }
        Console.WriteLine(maxValue);
    }
}

