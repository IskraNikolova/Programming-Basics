using System;

public class InsideTheBuilding
{
    public static void Main()
    {
        const int countOfPoint = 5;
        
        int h = int.Parse(Console.ReadLine());
        for (int i = 0; i < countOfPoint; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x >= 0 && x <= 3 * h) && (y >= 0 && y <= h) || (x <= 2 * h && x >= h) && (y >= h && y <= 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}

