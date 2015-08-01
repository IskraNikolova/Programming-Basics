using System;
using System.Linq;

public class NumberComparer
{
    /// <summary>
    /// Write a program that gets two numbers from the console and prints the greater of them.
    /// </summary>
    public static void Main()
    {

        int[] numbers = new int[2];
        numbers[0] = int.Parse(Console.ReadLine());
        numbers[1] = int.Parse(Console.ReadLine());

        Console.WriteLine(numbers.Max());
    }
}

