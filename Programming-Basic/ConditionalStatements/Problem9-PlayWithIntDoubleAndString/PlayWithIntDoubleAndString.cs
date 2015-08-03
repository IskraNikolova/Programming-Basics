using System;

public class PlayWithIntDoubleAndString
{
    public static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        string inputSelection = Console.ReadLine();

        if (inputSelection == "1")
        {
            Console.Write("Please enter a int: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int result = inputNumber + 1;

            Console.WriteLine(result);
        }
        else if (inputSelection == "2")
        {
            Console.Write("Please enter a double: ");
            double inputNumber = double.Parse(Console.ReadLine());
            double result = inputNumber + 1;

            Console.WriteLine(result);
        }
        else if (inputSelection == "3")
        {
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine(input + '*');
        }
     }
}

