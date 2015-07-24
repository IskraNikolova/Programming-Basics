using System;

public class CirclePerimeterAndArea
{
    /// <summary>
    /// Write a program that reads the radius r of a circle and prints its perimeter and area 
    /// formatted with 2 digits after the decimal point.
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write radius of circle: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeterOfCircle = 2*(Math.PI*radius);
            
        double  powRadius = Math.Pow(radius, 2);
        double areaOfCircle = Math.PI*powRadius;

        Console.WriteLine("perimeter: {0:F2} area: {1:F2}", perimeterOfCircle, areaOfCircle);
    }
}

