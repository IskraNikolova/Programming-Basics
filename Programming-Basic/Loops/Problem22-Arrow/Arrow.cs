using System;
using System.Globalization;

public class Arrow
{
    public static void Main()
    {
        int sizeOfArrow = int.Parse(Console.ReadLine());

        string dots = new string('.', sizeOfArrow/2);
        string arrowTop = new string('#', sizeOfArrow);
        string firstLine = string.Format("{0}{1}{0}", dots, arrowTop);
        Console.WriteLine(firstLine);

        int length = sizeOfArrow - 2;
        string innerDots = new string('.', length);
        for (int i = 0; i < length; i++)
        {
            
            string middleOfArow = String.Format("{0}#{1}#{0}", dots, innerDots);
            Console.WriteLine(middleOfArow);
        }
        string outOfArrow = new string('#', (sizeOfArrow + 1)/2);
        string middleLineOfArrow = String.Format("{0}{1}{0}",outOfArrow, innerDots);
        Console.WriteLine(middleLineOfArrow);

        for (int i = 1; i <= length; i++)
        {
            string outDots = new string('.', i);
            int countOfInnerDots = (((sizeOfArrow*2) - 1) - 2*i) - 2;
            string innerDotsOfDown = new string('.', countOfInnerDots);
            string arrowDown = String.Format("{0}#{1}#{0}", outDots, innerDotsOfDown);
            Console.WriteLine(arrowDown);
        }

        string outLastLineDots = new string('.', sizeOfArrow - 1);
        string lastLineOfArrow = String.Format("{0}#{0}", outLastLineDots);
        Console.WriteLine(lastLineOfArrow);
    }
}

