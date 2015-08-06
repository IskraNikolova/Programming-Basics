using System;

public class RandomNumbersInGivenRange
{
    /// <summary>
    /// a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers
    ///  in the range [min...max].
    /// </summary>
    public static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());

        Console.Write("min=");
        int minNumber = int.Parse(Console.ReadLine());

        Console.Write("max=");
        int maxNumber = int.Parse(Console.ReadLine());

        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", random.Next(minNumber, maxNumber+ 1));
        }
    }
}

