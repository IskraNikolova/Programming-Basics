using System;

public class NumbersFrom1ToN
{
    /// <summary>
    /// Write a program that reads an integer number n from the console and prints all 
    /// the numbers in the interval [1..n], each on a single line
    /// </summary>
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        for (int number = 1; number <= inputNumber; number++)
        {
            Console.WriteLine(number);
        }
    }
}

