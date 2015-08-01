using System;

public class ModifyABitAtGivenPosition
{
    /// <summary>
    /// We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
    /// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position
    ///  p from the binary representation of n while preserving all other bits in n.
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write a number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        Console.Write("Please write a position: ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Please write a value: ");
        int value = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask = ~(1 << position);
            inputNumber = inputNumber & mask;
            Console.WriteLine(inputNumber);
        }
        else
        {
            int mask = 1 << position;
            inputNumber = inputNumber | mask;
            Console.WriteLine(inputNumber);
        }
    }
}

