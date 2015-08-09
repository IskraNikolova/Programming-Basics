using System;

public class DifferenceBetweenDates
{
    /// <summary>
    /// A program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
    /// </summary>
    public static void Main()
    {
        Console.Write("Write first date in format (dd.MM.yyyy): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Write second date in format (dd.MM.yyyy): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        
        Console.WriteLine("Days between: {0}", (secondDate - firstDate).Days);
    }
}

