using System;

public class SpiralMatrix
{
    /// <summary>
    /// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints
    ///  a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("n= ");
        int matrixSize = int.Parse(Console.ReadLine());

        int[,] matrix = new int[matrixSize,matrixSize];
        int row = 0;
        int col = 0;

        string direction = "right";
        double maxLength = Math.Pow(matrixSize, 2);

        for (int i = 1; i <= maxLength; i++)
        {
            if (direction == "right" && (col > matrixSize - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > matrixSize - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && matrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        for (int rows = 0; rows < matrixSize; rows++)
        {
            for (int columns = 0; columns < matrixSize; columns++)
            {
                Console.Write("{0, 4}", matrix[rows, columns]);
            }
            Console.WriteLine();
        }
    }
}

