using System;

public class NewHouse
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        string elementOfFirstLine = new string('-',(inputNumber - 1)/2);
        string firstAsterisk = "*";
        Console.WriteLine("{0}{1}{2}", elementOfFirstLine, firstAsterisk, elementOfFirstLine);

        int countOfAsterisk = 3;
        int lengthForLoop = inputNumber/2;
        for (int i = 0; i < lengthForLoop; i++)
        {
            int countOfDash = (inputNumber - countOfAsterisk) / 2;
            string dash = new string('-', countOfDash);
            string asterisks = new string('*', countOfAsterisk);
            Console.WriteLine("{0}{1}{0}", dash, asterisks);
            countOfAsterisk += 2;
        }

        for (int i = 0; i < inputNumber; i++)
        {
            string downAsterisk = new string('*', inputNumber - 2);
            Console.WriteLine("|{0}|", downAsterisk);
        }
    }
}

