using System;

public class Sunglasses
{
    public static void Main()
    {
        int numberOfSize = int.Parse(Console.ReadLine());
        string firstAndLastLine = new string('*',2*numberOfSize) 
                         + new string(' ', numberOfSize)
                         + new string('*', 2* numberOfSize);
        Console.WriteLine(firstAndLastLine);

        int currentLength = numberOfSize - 2;
        int countOfGlassSymbol = (numberOfSize * 2) - 2;
        string glass = new string('/', countOfGlassSymbol);
        for (int line = 0; line < currentLength; line++)
        {
            string leftRightGlass = "*" + glass + "*";
            int halfLength = currentLength / 2;
            if (line == halfLength)
            {
                string bridge = new string('|', numberOfSize);
                Console.WriteLine(leftRightGlass + bridge + leftRightGlass);
            }
            else
            {
                string spaceBetween = new string(' ', numberOfSize);
                Console.WriteLine(leftRightGlass + spaceBetween + leftRightGlass);
            }
        }

        Console.WriteLine(firstAndLastLine);
    }
}

