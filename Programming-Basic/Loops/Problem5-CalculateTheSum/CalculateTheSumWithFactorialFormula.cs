using System;

public class Calculate1X
{
    public static void Main()
    {
        Console.Write("n = ");
        int lengthOfLoop = int.Parse(Console.ReadLine());

        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double factorial = 1;
        double divisor = 1;
        double sum = 1;
        for (int i = 1; i <= lengthOfLoop; i++)
        {
            factorial *= i;
            divisor *= x;
            sum += factorial/divisor;
        }

        Console.WriteLine("{0:F5}", sum);
    }
}

