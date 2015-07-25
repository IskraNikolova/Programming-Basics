using System;
using System.Numerics;

public class FibonacciNumbers
{
    /// <summary>
    /// Write a program that reads a number n and prints on the console the first n members 
    /// of the Fibonacci sequence (at a single line, separated by spaces) 
    /// </summary>
    public static void Main()
    {
        int firstNumbersMembersOfFibonacci = int.Parse(Console.ReadLine());

        if (firstNumbersMembersOfFibonacci == 1)
        {
            Console.WriteLine(0);
        }

        else
        {
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger thirdNumber = 0;

            Console.Write("{0} {1} ", firstNumber, secondNumber);

            for (int index = 2; index < firstNumbersMembersOfFibonacci; index++)
            {
                thirdNumber = firstNumber + secondNumber;

                Console.Write(thirdNumber + " ");

                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
        }

    }
}

