using System;

public class DecimalToHexadecimal
{
    /// <summary>
    /// Using loops write a program that converts an integer number to its hexadecimal representation. 
    /// The input is entered as long. The output should be a variable of type string. Do not use 
    /// the built-in .NET functionality. 
    /// </summary>
    public static void Main()
    {
        Console.Write("Please write decimal number: ");
        long decimalToHexadecimal = long.Parse(Console.ReadLine());
        ToHexadecimal(decimalToHexadecimal);
        Console.ReadKey();
    }
    static void ToHexadecimal(long decimalToHex)
    {
        if (decimalToHex == 0)
        {
            return;
        }
         
         else
        {
            long rest = decimalToHex % 16;
            decimalToHex /= 16;
            ToHexadecimal(decimalToHex);

            switch (rest)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default:
                    Console.Write(rest);
                    break;

            }
        }
    }
}


