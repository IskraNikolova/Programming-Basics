using System;

public class Trapezoids
{
    /// <summary>
    /// Write an expression that calculates trapezoid's area by given sides a and b and height h. 
    /// </summary>
    public static void Main()
    {
        const double multiplier = 0.5;

        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("h: ");
        double h = double.Parse(Console.ReadLine());

        double area = multiplier*((a + b)*h);
        Console.WriteLine("Area of trapezoid is: {0}", area);
    }
}

