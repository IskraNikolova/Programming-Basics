using System;

public class CalculateNK
{
    /// <summary>
    /// A program that calculates n! / k! for given n and k.
    /// </summary>
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;

        for (int i = n; i > 1; i--)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }

        double result = factorialN/factorialK;
        Console.WriteLine((int)result);
    }
}

