using System;
using System.Collections.Generic;
using System.Linq;

public class OddOrEvenElements
{
    public static void Main()
    {
        double[] collectionOfInputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        List<double> oddNumbers = new List<double>();
        List<double> evenNumbers = new List<double>();

        for (int i = 0; i < collectionOfInputNumbers.Length; i++)
        {
            if (i%2 == 0)
            {
                oddNumbers.Add(collectionOfInputNumbers[i]);
            }
            else
            {
                evenNumbers.Add(collectionOfInputNumbers[i]);
            }
        }

        double oddSum = oddNumbers.Sum();
        double oddMin = oddNumbers.Min();
        double oddMax = oddNumbers.Max();
        if (evenNumbers.Count == 0 && oddNumbers.Count == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No",
                           oddSum);
        }
        else
        {
            double evenSum = evenNumbers.Sum();
            double evenMin = evenNumbers.Min();
            double evenMax = evenNumbers.Max();

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                                oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }

    }
}

