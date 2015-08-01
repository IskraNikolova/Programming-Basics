using System;

public class PointInsideACircleAndOutsideOfRectangle
{
    public static void Main()
    {
        const double radius = 1.5;

        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());

        double z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        bool isInsideOfCircle = z <= radius;
        bool isOutsideOfRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);

        if (isInsideOfCircle && isOutsideOfRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

