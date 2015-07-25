using System;

public class WorkHours
{
    public static void Main()
    {
        const double bikingTime = 0.1;
        const int hoursOnDay = 12;
        const double precentConvert = 0.01;

        int workHoursToFinish = int.Parse(Console.ReadLine());

        int daysAvailableToFinish = int.Parse(Console.ReadLine());

        int productivityPrecent = int.Parse(Console.ReadLine());
        double precentToDouble = productivityPrecent*precentConvert;
        
        double timeToBicycle = daysAvailableToFinish*bikingTime;
        double clearWorkDays = daysAvailableToFinish - timeToBicycle;

        double hoursWork = clearWorkDays*hoursOnDay;
        double efficientWorkHours = hoursWork*precentToDouble;

        double result = (int)efficientWorkHours - workHoursToFinish;
        if (result < 0)
        {
            Console.WriteLine("No\n{0}", result);
        }
        else
        {
            Console.WriteLine("Yes\n{0}", result);
        }
    }   
}

