using System;
using System.Text;

public class NineDigitMagicNumbers
{
    public static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int resultCounter = 0;

        int biggestNumber = 777;
        int smallestNumber = 111;
        for (int firstNumber = smallestNumber; firstNumber <= biggestNumber; firstNumber++)
        {
            int secondNumber = firstNumber + diff;
            int thirdNumber = secondNumber + diff;

            if (isOfRangeDigit(firstNumber)
                    && isOfRangeDigit(secondNumber)
                    && isOfRangeDigit(thirdNumber) 
                    && firstNumber <= 777)
            {
                StringBuilder allDigit = new StringBuilder();
                {
                    allDigit.Append(firstNumber);
                    allDigit.Append(secondNumber);
                    allDigit.Append(thirdNumber);
                }

                string allDigits = allDigit.ToString();
                if (CalculateSumOfDigit(allDigits) == sum)
                {
                    Console.WriteLine(allDigits);
                    resultCounter++;
                }
            }
        }

        if (resultCounter == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static bool isOfRangeDigit(int number)
    {
        string numberToDigit = number.ToString();
        int countOfCorrectDigit = 0;
        for (int i = 0; i < numberToDigit.Length; i++)
        {

            int digit = int.Parse(numberToDigit[i].ToString());
            if (digit <= 7 && digit > 0)
            {
                countOfCorrectDigit++;
            }
        }
        if (countOfCorrectDigit == 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static int CalculateSumOfDigit(string allDigits)
    {
        int sumOfDigit = 0;
        for (int i = 0; i < allDigits.Length; i++)
        {
            sumOfDigit += int.Parse(allDigits[i].ToString());
        }

        return sumOfDigit;
    }
}

