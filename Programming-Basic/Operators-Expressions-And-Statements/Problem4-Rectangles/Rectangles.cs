using System;

public class Rectangles
{
    /// <summary>
    /// Write an expression that calculates rectangle’s perimeter and area by given width and height.
    /// </summary>
    public static void Main()
    {
        Console.Write("width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeterOfRectangle = 2*(width + height);
        double areaOfRectangle = width*height;

        Console.WriteLine("perimeter: {0}\narea: {1}", perimeterOfRectangle, areaOfRectangle);
    }
}

