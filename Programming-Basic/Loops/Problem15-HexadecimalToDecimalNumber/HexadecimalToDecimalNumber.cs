using System;
using System.Collections.Generic;

public class HexadecimalToDecimalNumber
{
    /// <summary>
    /// Using loops write a program that converts a hexadecimal integer number to its decimal form. 
    /// The input is entered as string. The output should be a variable of type long. Do not use 
    /// the built-in .NET functionality.
    /// </summary>
    public static void Main()
    {
        string hexadecimal = Console.ReadLine();

        List<int> numbers = new List<int>();
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            switch (hexadecimal[i])
            {
                case 'A':
                    numbers.Add(10);
                    break;
                case 'B':
                    numbers.Add(11);
                    break;
                case 'C':
                    numbers.Add(12);
                    break;
                case 'D':
                    numbers.Add(13);
                    break;
                case 'E':
                    numbers.Add(14);
                    break;
                case 'F':
                    numbers.Add(15);
                    break;
                default:
                    numbers.Add(int.Parse(hexadecimal[i].ToString()));
                    break;
            }
         }

        double sum = 0;
        for (int i = numbers.Count; i > 0; i--)
        {
            int index = numbers.Count - i;
            sum += numbers[index]*Math.Pow(16, i - 1);
        }

        Console.WriteLine(sum);
    }
}

