using System;
using System.Text.RegularExpressions;

public class ExtractURLsFromText
{
    /// <summary>
    /// A program that extracts and prints all URLs from given text. URL can be in only two formats:
    ///http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
    ///www.something.domain, e.g.www.nakov.com, www.softuni.bg, www.google.com
    /// </summary>
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

