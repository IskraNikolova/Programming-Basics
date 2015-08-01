using System;

public class pointInACircle
{
    /// <summary>
    /// Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).
    /// </summary>
    public static void Main()
    {
        const int radius = 2;

        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());

        double z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        Console.WriteLine(z <= radius);
    }
}

