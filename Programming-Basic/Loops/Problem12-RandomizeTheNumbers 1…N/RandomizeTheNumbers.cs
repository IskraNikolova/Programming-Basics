using System;
using System.Linq;

public class RandomizeTheNumbers
{
    /// <summary>
    /// A program that enters in integer n and prints the numbers 1, 2, …, n in random order. 
    /// </summary>
    public static void Main()
    {
        Console.Write("n = ");
        int lengthOfCollection = int.Parse(Console.ReadLine());

        int[] collectionOfNumbers = new int[lengthOfCollection];
        for (int index = 0; index < lengthOfCollection; index++)
        {
            collectionOfNumbers[index] = index;
        }

        Random random = new Random();
        collectionOfNumbers = Enumerable.Range(1, lengthOfCollection).OrderBy(r => random.Next()).ToArray();

        for (int index = 0; index < lengthOfCollection; index++)
        {
            Console.Write("{0} ", collectionOfNumbers[index]);
        }
    }
}

