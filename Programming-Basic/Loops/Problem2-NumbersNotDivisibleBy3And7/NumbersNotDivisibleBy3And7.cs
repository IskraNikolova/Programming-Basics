using System;

public class NumbersNotDivisibleBy3And7
{
    /// <summary>
    /// Write a program that enters from the console a positive integer n 
    /// and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Write a number: ");
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

