using System;

public class BitExchange
{
    /// <summary>
    /// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
    /// </summary>
    public static void Main()
    {
        const int firstPosition = 3;
        const int secondPosition = 24;

        uint inputNumber = uint.Parse(Console.ReadLine());

        uint firstBits = inputNumber >> firstPosition;
        firstBits = firstBits & 7;

        uint secondBits = inputNumber >> secondPosition;
        secondBits = secondBits & 7;

        uint maskFirstBits = 7 << firstPosition;
        uint maskSecondBits = 7 << secondPosition;

        inputNumber = inputNumber & ~maskFirstBits | (secondBits << firstPosition);
        inputNumber = inputNumber & ~maskSecondBits | (firstBits << secondPosition);

        Console.WriteLine(inputNumber);
    }
}

