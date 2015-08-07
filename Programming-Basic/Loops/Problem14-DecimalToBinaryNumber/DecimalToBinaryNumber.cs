using System;
using System.Collections.Generic;

public class DecimalToBinaryNumber
{
    /// <summary>
    /// A program that converts an integer number to its binary representation. 
    /// The input is entered as long. The output should be a variable of type string. Do not use the built-in 
    /// .NET functionality. 
    /// </summary>
    public static void Main()
    {
        long decimalToBinaryNum = long.Parse(Console.ReadLine());
        List<string> binaryNumber = new List<string>();

        while (decimalToBinaryNum != 0)
        {
            if (decimalToBinaryNum%2 == 0)
            {
                binaryNumber.Add("0");
            }
            else
            {
                binaryNumber.Add("1");
            }

            decimalToBinaryNum = decimalToBinaryNum/2;
        }

        for (int i = binaryNumber.Count; i > 0; i--)
        {
            Console.Write(binaryNumber[i - 1]);
        }
        Console.WriteLine();
        
    }
}

