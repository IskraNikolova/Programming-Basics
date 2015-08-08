using System;


public class DecimalToHexadecimal
{
    public static void Main()
    {
        int decimalToHexadecimal = int.Parse(Console.ReadLine());
        ToHexadecimal(decimalToHexadecimal);
        Console.ReadKey();
    }
    static void ToHexadecimal(int decimalToHex)
    {
        if (decimalToHex == 0)
        {
            return;
        }
         
         else
        {
            int rest = decimalToHex % 16;
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


