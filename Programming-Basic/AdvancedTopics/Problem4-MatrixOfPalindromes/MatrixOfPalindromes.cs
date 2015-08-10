using System;

public class MatrixOfPalindromes
{
    /// <summary>
    /// Write a program to generate the following matrix of palindromes of 3 letters 
    /// with r rows and c columns:
    /// </summary>
    public static void Main()
    {
        Console.Write("rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("columns: ");
        int columns = int.Parse(Console.ReadLine());
        char a = '\0';
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                char[] str = new char[3];
                for (int i = 0; i < str.Length; i++)
                {
                  
                    if (i != 1)
                    {
                        a = (char)(97 + row);
                        str[i] = a;
                    }
                    else
                    {
                        char b = (char)(a + col);
                        str[i] = b;
                    }
                 
                }
                Console.Write(string.Join("", str));
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

