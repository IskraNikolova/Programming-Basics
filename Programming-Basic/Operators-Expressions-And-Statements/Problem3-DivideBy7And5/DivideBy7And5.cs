using System;

public class DivideBy7And5
{
    /// <summary>
    /// Write a Boolean expression that checks for given integer
    ///  if it can be divided (without remainder) by 7 and 5 in the same time. 
    /// </summary>
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        bool isDivideBy7And5 = inputNumber%7 == 0 && inputNumber%5 == 0;

        Console.WriteLine(isDivideBy7And5);
    }
}

