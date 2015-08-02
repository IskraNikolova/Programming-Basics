using System;

public class BonusScore
{
    /// <summary>
    /// Write a program that applies bonus score to given score in the range [1…9] by the following 
    /// </summary>
    public static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if (score > 0 && score < 4)
        {
            int bonusScore = score * 10;
            Console.WriteLine(bonusScore);
        }
        else if (score > 3 && score < 7)
        {
            int bonusScore = score * 100;
            Console.WriteLine(bonusScore);
        }
        else if (score > 6 && score < 10)
        {
            int bonusScore = score * 1000;
            Console.WriteLine(bonusScore);
        }
        else if (score <= 0 || score > 9)
        {
            Console.WriteLine("invalid score");
        }
    }
}

