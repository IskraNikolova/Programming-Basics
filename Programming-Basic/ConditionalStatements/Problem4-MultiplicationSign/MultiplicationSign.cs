using System;

public class MultiplicationSign
{
    /// <summary>
    /// Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
    /// without calculating it. Use a sequence of if operators
    /// </summary>
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int multiplication = a*b*c;

        if (multiplication > 0)
        {
            Console.WriteLine("+");
        }
        else if (multiplication == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

