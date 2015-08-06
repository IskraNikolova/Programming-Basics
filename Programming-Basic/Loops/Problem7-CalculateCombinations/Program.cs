using System;
using System.Xml.Schema;

public class CalculateCombination
{
    /// <summary>
    /// n! / (k! * (n-k)!) 
    /// </summary>
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int length = k;
        int result = n;
        for (int i = 1; i < length; i++)
        {
            result *= n - i;
        }

        int resultK = 1;
        for (int i = k; i > 1; i--)
        {
            resultK *= i;
        }
        Console.WriteLine(result/resultK);
    }
}

