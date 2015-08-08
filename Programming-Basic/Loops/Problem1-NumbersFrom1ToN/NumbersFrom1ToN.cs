using System;

public class NumbersFrom1ToN
{
    /// <summary>
    /// Program that enters from the console a positive integer n and prints all the numbers 
    /// from 1 to n, on a single line, separated by a space.
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write a number: ");
        int lengthForLoop = int.Parse(Console.ReadLine());

        for (int number = 1; number <= lengthForLoop; number++)
        {
            Console.Write("{0} ", number);
        }
    }
}

