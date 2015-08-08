using System;
using System.Numerics;

public class TrailingZeroesInN
{
    /// <summary>
    /// Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
    /// Your program should work well for very big numbers, e.g. n=100000. 
    /// </summary>
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = n;
        for (int i = 1; i < n; i++)
        {
            factorial *= n - i;
        }

        string factorialToString = factorial.ToString();
        int countOfZero = 0;
        for (int i = factorialToString.Length - 1; i > 0 ; i--)
        {
            if (factorialToString[i] != '0')
            {
                break;
            }
            else
            {
                countOfZero++;
            }
        }

        Console.WriteLine(countOfZero);
    }
}

