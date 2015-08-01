using System;

public class ExtractBitFromInteger
{
    /// <summary>
    /// Expression that extracts from given integer n the value of given bit at index p. 
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        Console.Write("Please write position: ");
        int position = int.Parse(Console.ReadLine());

        int nRight = inputNumber >> position;
        int bit = nRight & 1;

        Console.WriteLine(bit);
    }
}

