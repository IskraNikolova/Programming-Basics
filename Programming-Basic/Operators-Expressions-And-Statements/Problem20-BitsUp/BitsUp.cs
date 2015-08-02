using System;

public class BitsUp
{
    public static void Main()
    {
        const int count = 7;

        int countOfNumbers = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;

        for (int i = 0; i < countOfNumbers; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int j = count; j >= 0; j--)
            {
                if ((index%step == 1) || (step == 1 && index > 0))
                {
                    int mask = 1 << j;
                    inputNumber = inputNumber | mask;
                }
                index++;
            }
            Console.WriteLine(inputNumber);
        }
    }
}

