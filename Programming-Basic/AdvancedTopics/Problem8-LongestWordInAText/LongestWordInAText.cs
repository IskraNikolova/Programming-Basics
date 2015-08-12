using System;

public class LongestWordInAText
{
    /// <summary>
    /// Write a program to find the longest word in a text.
    /// </summary>
    public static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');

        string longestWord = string.Empty;
        int count = 0;
        int longestCount = 0;
        for (int i = 0; i < text.Length; i++)
        {
            count = text[i].Length;
            if (count > longestCount)
            {
                longestCount = count;
                longestWord = text[i];
            }
        }

        Console.WriteLine(longestWord);
    }
}

