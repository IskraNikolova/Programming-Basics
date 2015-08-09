using System;

public class LongestAreaInArray
{
    /// <summary>
    /// Write a program to find the longest area of equal elements in array of strings. 
    /// You first should read an integer n and n strings (each at a separate line), 
    /// then find and print the longest sequence of equal elements (first its length, then its elements). 
    /// If multiple sequences have the same maximal length, print the leftmost of them.
    /// </summary>
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] collectionOfStrings = new string[n]; 
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            collectionOfStrings[i] = input;
        }
        int count = 1;
        int maxCount = 0;
        string maxSequence = string.Empty;
        for (int i = 0; i < collectionOfStrings.Length - 1; i++)
        {
            if (collectionOfStrings[i] == collectionOfStrings[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
                {
                    maxCount = count;
                    maxSequence = collectionOfStrings[i];
                }
          
        }

        Console.WriteLine(maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            Console.WriteLine(maxSequence);
        }
   
    }
}

