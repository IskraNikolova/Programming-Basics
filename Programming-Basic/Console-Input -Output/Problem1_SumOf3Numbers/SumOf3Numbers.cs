using System;

public class SumOf3Numbers
{
    /// <summary>
    /// Get the sum of three real numbers and write it on the console.
    /// </summary>
    public static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine(sum);
    }
}

