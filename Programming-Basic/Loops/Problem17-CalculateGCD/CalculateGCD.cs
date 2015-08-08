using System;

public class CalculateGCD
{
    /// <summary>
    /// Write a program that calculates the greatest common divisor (GCD) of given
    ///  two integers a and b. Use the Euclidean algorithm (find it in Internet). 
    /// </summary>
    public static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int c = a%b;
        while (a%b != 0)
        {
            a = b;
            b = c;
            c = a%b;
        }
        Console.WriteLine(b);
    }
}
