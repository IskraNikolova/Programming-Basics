using System;

public class House
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string dots = new string('.', n/2);
        string asterisk = "*";
        string firstLine = String.Format("{0}{1}{0}", dots, asterisk);

        Console.WriteLine(firstLine);
        int length = (n/2) - 1;
        for (int i = 0; i < length; i++)
        {
            int countOfOutDots = (n - (3 + (2*i)))/2;
            string outDots = new string('.', countOfOutDots);

            int countOfInnerDots = (n - (countOfOutDots*2)) - 2;
            string innerDots = new string('.', countOfInnerDots);

            Console.WriteLine("{0}*{1}*{0}", outDots, innerDots);
        }
        string roofsDown = new string('*', n);
        Console.WriteLine(roofsDown);

        int length2 = n - (length + 3);
        int countOfOutDot = n / 4;
        string outDots2 = new string('.', countOfOutDot);
        for (int i = 0; i < length2; i++)
        {
           

            int countOfInnerDots = (n-2)-(countOfOutDot*2);
            string innerDots = new string('.', countOfInnerDots);

            Console.WriteLine("{0}*{1}*{0}", outDots2, innerDots);
        }
        int countOfAsterisk = n - (countOfOutDot*2);
        string asteriskDown = new string('*', countOfAsterisk);
        Console.WriteLine("{0}{1}{0}", outDots2, asteriskDown);
    }
}

