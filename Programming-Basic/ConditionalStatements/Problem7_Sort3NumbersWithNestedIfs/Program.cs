using System;

public class Sort3NumbersWithNestedIfs
{
    /// <summary>
    /// Program that enters 3 real numbers and prints them sorted in descending order. 
    /// Use nested if statements.  
    /// </summary>
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double firstNumber = 0;
        double secondNumber = 0;
        double thirdNumber = 0;

        if (a > b && a > c)
        {
            firstNumber = a;
            if (b > c)
            {
                secondNumber = b;
                thirdNumber = c;
            }
            else
            {
                secondNumber = c;
                thirdNumber = b;
            }
        }
        else if (b > a && b > c)
        {
            firstNumber = b;
            if (a > c)
            {
                secondNumber = a;
                thirdNumber = c;
            }
            else
            {
                secondNumber = c;
                thirdNumber = a;
            }
        }
        else if (c > a && c > b)
        {
            firstNumber = c;
            if (a > b)
            {
                secondNumber = a;
                thirdNumber = b;
            }
            else
            {
                secondNumber = b;
                thirdNumber = a;
            }
        }
        Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);

    }
}