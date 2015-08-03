using System;

public class BeerTime
{
    public static void Main()
    {
        Console.WriteLine("Enter time");
        DateTime hourInput = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(hourInput.ToString("hh:mm tt"));

        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 AM");


        if (hourInput >= startBeerTime || hourInput <= endBeerTime)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
            
    }
}

