using System;

public class BitExchangeAdvanced
{
    /// <summary>
    /// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}
    ///  of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. 
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write number: ");
        uint inputNumber = uint.Parse(Console.ReadLine());

        Console.Write("Please write p: ");
        int firstPosition = int.Parse(Console.ReadLine());

        Console.Write("Please write q: ");
        int secondPosition = int.Parse(Console.ReadLine());

        Console.Write("Please write k: ");
        int step = int.Parse(Console.ReadLine());

        int firstPositionsCalculate = firstPosition + step;

        if (Math.Max(firstPosition, secondPosition) + step > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (Math.Min(firstPosition, secondPosition) + step > Math.Max(firstPosition, secondPosition))
        {
            Console.WriteLine("Overlapping");
            return;
        }
        else
        {
            for (int i = 0; i < step; i++)
            {
                uint firstBits = inputNumber >> firstPosition + i;
                firstBits = firstBits & 1;

                uint secondBits = inputNumber >> secondPosition + i;
                secondBits = secondBits & 1;

                int maskFirstBits = 1 << firstPosition + i;
                int maskSecondBits = 1 << secondPosition + i;

                inputNumber = inputNumber & (uint)~maskFirstBits | (secondBits << (firstPosition + i));
                inputNumber = inputNumber & (uint)~maskSecondBits | (firstBits << (secondPosition + i));
            }

            Console.WriteLine(inputNumber);
        }
   
    }
}

