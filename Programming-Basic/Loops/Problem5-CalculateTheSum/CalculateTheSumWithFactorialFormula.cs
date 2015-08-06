using System;

public class CalculateTheSumWithFactorialFormula
{
    /// <summary>
    /// Program that, for a given two integer numbers n and x, 
    /// calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop.
    ///  Print the result with 5 digits after the decimal point.
    /// </summary>
    public static void Main()
    {
        Console.Write("n = ");
        int lengthOfLoop = int.Parse(Console.ReadLine());

        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double factorial = 1;
        double divisor = 1;
        double sum = 1;
        for (int i = 1; i <= lengthOfLoop; i++)
        {
            factorial *= i;
            divisor *= x;
            sum += factorial/divisor;
        }

        Console.WriteLine("{0:F5}", sum);
    }
}

