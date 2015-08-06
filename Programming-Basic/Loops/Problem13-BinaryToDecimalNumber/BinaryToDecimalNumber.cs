using System;

public class BinaryToDecimalNumber
{
    /// <summary>
    /// Using loops write a program that converts a binary integer number to its decimal form. 
    /// The input is entered as string.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Enter a Binary number:");
        string binaryNumber = Console.ReadLine();
        byte[] binarics = new byte[binaryNumber.Length];
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            binarics[i] = byte.Parse(Convert.ToString((binaryNumber[i])));
        }
        Array.Reverse(binarics);

        long numDecimal = 0;
        long multiplier = 1;
        foreach (var digit in binarics)
        {
            numDecimal += (digit * multiplier);
            multiplier *= 2;
        }

        Console.WriteLine("{0}", numDecimal);
    }
}

