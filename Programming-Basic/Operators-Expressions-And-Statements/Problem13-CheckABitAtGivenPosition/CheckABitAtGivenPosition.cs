using System;

public class CheckABitAtGivenPosition
{
    /// <summary>
    /// Boolean expression that returns if the bit at position p 
    /// (counting from 0, starting from the right) in given integer number n has value of 1.
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        Console.Write("Please write position: ");
        int position = int.Parse(Console.ReadLine());

        int nRight = inputNumber >> position;
        int bit = nRight & 1;
        bool hasValue = (bit == 1);

        Console.WriteLine(hasValue);
    }
}

