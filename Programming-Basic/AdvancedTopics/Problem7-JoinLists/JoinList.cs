using System;
using System.Collections.Generic;
using System.Linq;

public class JoinList
{
    /// <summary>
    /// A program that takes as input two lists of integers and joins them. 
    /// The result should hold all numbers from the first list, and all numbers from the second list,
    ///  without repeating numbers, and arranged in increasing order. The input and output lists are given 
    /// as integers, separated by a space, each list at a separate line.
    /// </summary>
    public static void Main()
    {
        List<int> firstListOfInteger = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> secondListOfInteger = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < firstListOfInteger.Count; i++)
        {
            for (int j = 0; j < secondListOfInteger.Count; j++)
            {
                if (firstListOfInteger[i] == secondListOfInteger[j])
                {
                    secondListOfInteger.Remove(secondListOfInteger[j]);
                }
            }
        }

        for (int i = 0; i < secondListOfInteger.Count; i++)
        {
            firstListOfInteger.Add(secondListOfInteger[i]);
        }

        firstListOfInteger.Sort();

        Console.WriteLine(String.Join(" ", firstListOfInteger.Distinct()));

    }
}

