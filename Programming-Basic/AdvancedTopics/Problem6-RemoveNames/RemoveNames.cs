using System;

public class RemoveNames
{
    /// <summary>
    /// Wriprogram that takes as input two lists of names and removes from the first
    ///  list all names given in the second list. The input and output lists are given as words,
    ///  separated by a space, each list at a separate line.
    /// </summary>
    public static void Main()
    {
        string[] firstListOfNames = Console.ReadLine().Split(' ');

        string[] secondListOfNames = Console.ReadLine().Split(' ');

        for (int i = 0; i < firstListOfNames.Length; i++)
        {
            for (int j = 0; j < secondListOfNames.Length; j++)
            {
                if (firstListOfNames[i] == secondListOfNames[j])
                {
                    firstListOfNames[i] = null;
                }
            }
        }

        for (int i = 0; i < firstListOfNames.Length; i++)
        {
            if (!string.IsNullOrEmpty(firstListOfNames[i]))
            {
                Console.Write("{0} ",firstListOfNames[i]);
            }
            
        }
        Console.WriteLine();
    }
}

