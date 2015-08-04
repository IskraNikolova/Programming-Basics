using System;

public class Program
{
    public static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());


        double distanseAB = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2));
        double distanceBC = Math.Sqrt(Math.Pow((cX - bX), 2) + Math.Pow((cY - bY), 2));
        double distanceCA = Math.Sqrt(Math.Pow((cX - aX), 2) + Math.Pow((cY - aY), 2));

        if (distanseAB + distanceBC > distanceCA)
        {
            if (distanseAB + distanceCA > distanceBC)
            {
                if (distanceBC + distanceCA > distanseAB)
                {
                    Console.WriteLine("Yes");
                    double halfOfTriangPerimeter = (distanceCA + distanceBC + distanseAB)/2;
                    double area = Math.Sqrt(halfOfTriangPerimeter*(halfOfTriangPerimeter - distanseAB)
                              *(halfOfTriangPerimeter - distanceBC)*(halfOfTriangPerimeter - distanceCA));

                    Console.WriteLine("{0:F2}", area);
                    return;

                }
            }
        }

        Console.WriteLine("No");
        Console.WriteLine("{0:F2}", distanseAB);
    }
}


