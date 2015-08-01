using System;

public class FourDigitNumber
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int firstDigit = inputNumber%10;

        int toSecondDigit = inputNumber/10;
        int secondDigit = toSecondDigit%10;

        int toThirdDigit = inputNumber/100;
        int thirdDigit = toThirdDigit%10;

        int toFourDigit = inputNumber/1000;
        int fourDigit = toFourDigit%10;

        int sumOfAllDigit = firstDigit + secondDigit + thirdDigit + fourDigit;
        string reversed = String.Format("{0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourDigit);
        string lastDigitInFront = String.Format("{0}{1}{2}{3}", firstDigit, fourDigit, thirdDigit, secondDigit);
        string secondAndThirdExchanged = String.Format("{0}{1}{2}{3}", fourDigit, secondDigit, thirdDigit, firstDigit);

        Console.WriteLine("sum of digits: {0}\nreversed: {1}\nlast digit in front: {2}" +
                          "\nsecond and third digits exchanged: {3}",sumOfAllDigit, reversed,
                          lastDigitInFront, secondAndThirdExchanged);
    }
}

