using System;

public class TheBiggestOfFiveNumbers
{
    /// <summary>
    /// Write a program that finds the biggest of five numbers by using only five if statements. 
    /// </summary>
    public static void Main()
    {
        const int countOfNumbers = 5;

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
