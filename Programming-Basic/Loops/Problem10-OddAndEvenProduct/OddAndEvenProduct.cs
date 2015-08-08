using System;
using System.Linq;

public class OddAndEvenProduct
{
    /// <summary>
    /// a program that checks whether the product of the odd elements is equal to the product
    ///  of the even elements.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Please write a numbers with space!");
        int[] collectionOfInputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int oddProduct = 1;
        int evenProduct = 1;
        for (int index = 0; index < collectionOfInputNumbers.Length; index++)
        {
            if (index%2 == 0)
            {
                oddProduct *= collectionOfInputNumbers[index];
            }
            else
            {
                evenProduct *= collectionOfInputNumbers[index];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes\nproduct = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);

        }
    }
}

