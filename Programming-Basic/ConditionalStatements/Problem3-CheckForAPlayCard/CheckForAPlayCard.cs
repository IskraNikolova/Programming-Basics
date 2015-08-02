using System;
using System.Linq;

public class CheckForAPlayCard
{
    public static void Main()
    {
        string[] playCard = new[] {"2", "3", "4", "5", "6", "7", "8", "9", "10","J", "Q", "K", "A"};

        string checkSymbol = Console.ReadLine();

        if (playCard.Contains(checkSymbol))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

