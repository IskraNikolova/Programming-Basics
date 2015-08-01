using System;

public class BitwiseExtractBit3
{
    /// <summary>
    /// Expression for finding the value of the bit #3 of a given unsigned integer. 
    /// </summary>
    public static void Main()
    {
        const int position = 3;

        int inputNumber = int.Parse(Console.ReadLine());

        int nRight = inputNumber >> position;
        int bit = nRight & 1;

        Console.WriteLine(bit);
    }
}

