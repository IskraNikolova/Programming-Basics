
//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

public class QuotesInString
{
    public static void Main()
    {
        string firstVersion = "The \"use\" of quotations causes difficulties.";
        string secondVersion = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(firstVersion);
        Console.WriteLine(secondVersion);
    }
}

