using System;

public class JoroTheFootballPlayer
{
    public static void Main()
    {
        const int weekendsOfTheYear = 52;

        string leapYearsOrNo = Console.ReadLine();
        int numberOfHoliday = int.Parse(Console.ReadLine());
        int numberOfHometownWeekend = int.Parse(Console.ReadLine());

        int normalWeekend = weekendsOfTheYear - numberOfHometownWeekend;
        int playsOfNormalWeekends = normalWeekend*2/3;
        int playsOfHoliday = numberOfHoliday/2;

        int leapOrNo = 0;
        if (leapYearsOrNo == "t")
        {
            leapOrNo = 3;
        }

        int result = numberOfHometownWeekend + playsOfNormalWeekends + playsOfHoliday + leapOrNo;
        Console.WriteLine(result);
    }
}

