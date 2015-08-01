using System;

public class BitsInverter
{
    public static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        for (int i = 0; i < countOfNumbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                index++;
                if ((step == 1) || (index % step == 1))
                {
                    int mask = 1 << bit;
                    number = number ^ mask;
                }
            }

            Console.WriteLine(number);
        }
    }
}

