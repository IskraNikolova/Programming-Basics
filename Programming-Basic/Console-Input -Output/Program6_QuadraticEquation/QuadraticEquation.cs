using System;

public class QuadraticEquation
{
    /// <summary>
    /// Write a program that reads the coefficients a, b and c of a quadratic equation 
    /// ax2 + bx + c = 0 and solves it (prints its real roots). 
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please write b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please write c: ");
        double c = double.Parse(Console.ReadLine());

        SolveQuadratic(a, b, c);
    }

    public static void SolveQuadratic(double a, double b, double c)
    {
        double sqrtPart = b * b - 4 * a * c;
        double x1 = 0;
        double x2 = 0;

        if (sqrtPart > 0)
        {
            x1 = (-b - Math.Sqrt(sqrtPart)) / (2 * a);
            x2 = (-b + Math.Sqrt(sqrtPart))/(2*a);
         
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }

        else
        {
            Console.WriteLine("no real roots");
        }
     
    }
}

