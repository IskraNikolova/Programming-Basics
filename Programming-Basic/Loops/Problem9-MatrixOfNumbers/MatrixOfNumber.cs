using System;

public class MatrixOfNumber
{
    /// <summary>
    /// A program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
    /// and prints a matrix like in the examples below. Use two nested loops.
    /// </summary>
    public static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        int endIndex = matrixSize;

        for (int row = 1; row <= matrixSize; row++)
        {
            for (int column = row; column <= endIndex; column++)
            {
                Console.Write("{0} ", column);
            }

            endIndex++;
            Console.WriteLine();
        }
    }
}

