using System;

public class ThirdDigitIsSeven
{
    /// <summary>
    /// Expression that checks for given integer if its third digit from right-to-left is 7.
    /// </summary>
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int searchThirdDigit = inputNumber/100;
        int thirdDigit = searchThirdDigit%10;

        bool isSevenThirdDigit = false;
        if (thirdDigit == 7)
        {
            isSevenThirdDigit = true;
        }

        Console.WriteLine(isSevenThirdDigit);
    }
}

