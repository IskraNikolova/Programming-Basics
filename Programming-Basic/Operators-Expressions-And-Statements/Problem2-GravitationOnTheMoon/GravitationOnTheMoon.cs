using System;

public class GravitationOnTheMoon
{
    /// <summary>
    /// Calculates the weight of a man on the moon by a given weight on the Earth.
    /// </summary>
    public static void Main()
    {
        const double percent = 0.17;

        double weightOnTheEarth = double.Parse(Console.ReadLine());
        double weightOnTheMoon = weightOnTheEarth*percent;

        Console.WriteLine(weightOnTheMoon);
    }
}

