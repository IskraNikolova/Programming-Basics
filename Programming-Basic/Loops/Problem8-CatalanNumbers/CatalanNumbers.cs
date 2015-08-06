using System;

public class CatalanNumbers
{
    /// <summary>
    /// Write a program to calculate the nth Catalan number by given n
    /// </summary>
    public static void Main()
    {
        Console.Write("n = ");
        int lengthOfLoop = int.Parse(Console.ReadLine());

        ulong catalanNumber = Factorial(2*lengthOfLoop)/(Factorial(lengthOfLoop + 1)*Factorial(lengthOfLoop));
        Console.WriteLine("Catalan(n) {0}", catalanNumber);

    }

    static ulong Factorial(int lengthOfLoop)
    {
        ulong factorial = 1;
        for (uint i = 1; i <= lengthOfLoop; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}

