using System;

public class SortingNumbers
{
    /// <summary>
    /// Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
    /// </summary>
    public static void Main()
    {
        Console.Write("Write n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Write n numbers.");
        int[] numbersToSort = new int[n];
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbersToSort[i] = number;
        }

        Array.Sort(numbersToSort);

        foreach (var number in numbersToSort)
        {
            Console.WriteLine(number);
        }
    }
}

