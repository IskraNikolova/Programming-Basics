using System;
using System.Linq;

public class CheckForAPlayCard
{
    /// <summary>
    /// Classical play cards use the following signs to designate the card
    ///  face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
    /// and prints “yes” if it is a valid card sign or “no” otherwise.
    /// </summary>
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

