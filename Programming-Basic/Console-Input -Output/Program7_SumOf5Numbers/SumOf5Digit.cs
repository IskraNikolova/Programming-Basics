using System;
using System.Linq;

public class SumOf5Digit
{
    /// <summary>
    /// Write a program that enters 5 numbers 
    /// (given in a single line, separated by a space), calculates and prints their sum
    /// </summary>
    public static void Main()
    {
        double[] collectionOfNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        double sumOf5Digits = 0;
        for (int digit = 0; digit < collectionOfNumbers.Length; digit++)
        {
            sumOf5Digits += collectionOfNumbers[digit];
        }

        Console.WriteLine(sumOf5Digits);
    }
}

