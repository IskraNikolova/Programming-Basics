using System;
using System.Collections.Generic;

public class PrintADeckOf52Cards
{
    public static void Main()
    {
        const int countOfCards = 14;

        string spade = "\u2660";

        string clubSuit = "\u2663";

        string diamondSuit = "\u2666";

        string heartSuit = "\u2665";
        string[] cards =
        {
            "J", "Q", "K", "A"
        };

        for (int i = 0; i < countOfCards; i++)
        {
            if (i == 11)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", cards[i], clubSuit, diamondSuit, heartSuit, spade);
                }
            }
            else
            {
                Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i + 2, clubSuit, diamondSuit, heartSuit, spade);
            }
   
            
        }
      
    }
}

