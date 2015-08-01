using System;

public class SumOfN_Numbers
{
    /// <summary>
    /// Write a program that enters
    ///  a number n and after that enters more n numbers and calculates and prints their sum
    /// </summary>
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] inputNumbers = new int[input];

        int sum = 0;
        for (int index = 0; index < inputNumbers.Length; index++)
        {
            inputNumbers[index] = int.Parse(Console.ReadLine());
            sum += inputNumbers[index];
        }

        Console.WriteLine(sum);
    }
}

