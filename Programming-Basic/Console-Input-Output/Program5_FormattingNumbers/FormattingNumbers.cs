using System;

public class FormattingNumbers
{
    /// <summary>
    /// Write a program that reads 3 numbers and formatted.
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write an integer a (0 ≤ a ≤ 500): ");
        int a = int.Parse(Console.ReadLine());
        string aToHexadecimal = string.Format("{0:X}", a);
        string aToBinary = Convert.ToString(a, 2).PadLeft(10, '0');

        Console.Write("Please write floating-point b: ");
        double b = double.Parse(Console.ReadLine());
        string bWithTwoDigitAfter = String.Format("{0:F2}", b);

        Console.Write("Please write floating-point c: ");
        double c = double.Parse(Console.ReadLine());
        string bWithThreeDigitAfter = String.Format("{0:F3}", c);

        string formatResult = string.Format("|{0,-10}|{1}|{2,10}|{3,-10}|", 
                                             aToHexadecimal, 
                                             aToBinary, 
                                             bWithTwoDigitAfter, 
                                             bWithThreeDigitAfter);

        Console.WriteLine(formatResult);

    }
}

