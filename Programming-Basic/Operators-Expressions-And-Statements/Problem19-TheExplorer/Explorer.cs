using System;

public class Explorer
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = n/2;
        string dashCollection = new string('-', count);
        string asterisk = "*";
        string firstAndLastLine = String.Format("{0}{1}{0}", dashCollection, asterisk);

        Console.WriteLine(firstAndLastLine);

        for (int i = 0; i < count; i++)
        {
            int countOfOutDash = ((n - 3)/2) - i;
            int countOfInDash = (n - 2) - (countOfOutDash*2);

            string dashCollectionOut = new string('-', countOfOutDash);
            string dashCollectionIn = new string('-', countOfInDash);
            string topMiddleLines = String.Format("{0}{1}{2}{1}{0}", dashCollectionOut, 
                                                                    asterisk, 
                                                                    dashCollectionIn);

            Console.WriteLine(topMiddleLines);
         }

        for (int i = 1; i < count; i++)
        {
            int countOfDownInDash = (n - 2) - (i*2);
            string dashCollectionOut = new string('-', i);
            string dashCollectionIn = new string('-', countOfDownInDash);
            string downMiddleLines = String.Format("{0}{1}{2}{1}{0}", dashCollectionOut,
                                                                  asterisk,
                                                                  dashCollectionIn);

            Console.WriteLine(downMiddleLines);
         } 

        Console.WriteLine(firstAndLastLine);
    }
}

