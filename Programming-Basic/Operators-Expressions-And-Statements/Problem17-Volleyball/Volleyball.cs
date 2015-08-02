using System;

public class Volleyball
{
    public static void Main()
    {
        const int weekendsInTheYear = 48;

        string leapOrNo = Console.ReadLine();
        double daysOfHoliday = int.Parse(Console.ReadLine());
        double daysInHometown = int.Parse(Console.ReadLine());

        //Not at work in 3/4 of the normal weekends.
        double normalWeekends = ((weekendsInTheYear - daysInHometown) * 3)/4;

        //Plays in 2/3 of the holidays.
        double playInHolidays = (daysOfHoliday*2)/3;

        double totalPlays = daysInHometown + normalWeekends + playInHolidays;

        if (leapOrNo == "leap")
        {
            double addend = totalPlays*0.15;
            totalPlays = totalPlays + addend;
        }

        Console.WriteLine((int)totalPlays);
    }
}

