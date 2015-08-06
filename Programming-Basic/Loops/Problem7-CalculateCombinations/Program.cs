using System;
using System.Xml.Schema;

public class CalculateCombination
{
    /// <summary>
    ///  A program that calculates n! / (k! * (n-k)!) for given n and k.
    ///  n! / (k! * (n-k)!) = (n.(n – 1).(n – 2)...(n — k + 1))/(k(k – 1)...3.2.1)
    /// </summary>
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        //(n.(n – 1).(n – 2)...(n — k + 1))
        int resultN = n;
        for (int i = 1; i < k; i++)
        {
            resultN *= n - i;
        }

        //(k(k – 1)...3.2.1)
        int resultK = 1;
        for (int i = k; i > 1; i--)
        {
            resultK *= i;
        }
        Console.WriteLine(resultN/resultK);
    }
}

