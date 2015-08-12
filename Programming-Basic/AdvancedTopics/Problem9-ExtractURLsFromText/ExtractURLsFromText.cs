using System;
using System.Text.RegularExpressions;

public class ExtractURLsFromText
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"(www\.\w+\.\w+)|(http:\/\/\w+\.?\w+\.?\w+)";

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
       

    }
}

