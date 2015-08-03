using System;

public class NumberAsWords
{
    public static void Main()
    {
        string[] oneDigit =
        {
            "zero", "One", "Two",
            "Three", "Four", "Five",
            "Six", "Seven", "Eight", "Nine"
        };

        string[] twoDigitsToNineteen =
        {
            "Ten", "Eleven", "Twelve",
            "Thirteen", "Fourteen", "Fifteen",
            "Sixteen", "Seventeeen", "Eighteen", "Nineteen"
        };

        string[] twoDigitsToNinety =
        {
            "Twenty", "thirty", "Forty",
            "Fifty", "Sixty", "Seventy",
            "Eighty", "Ninety"
        };

        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber < 10)
        {
            Console.WriteLine(oneDigit[inputNumber]);
        }
        else if (inputNumber > 9 && inputNumber < 20)
        {
            int index = inputNumber%10;
            Console.WriteLine(twoDigitsToNineteen[index]);
        }
        else if (inputNumber >= 20 && inputNumber <= 99)
        {
            int index = (inputNumber - 20)/10;

            int searchFirstDigitOfNumber = inputNumber/10;
            int firstDigitToIndex = (searchFirstDigitOfNumber%10) - 2;

            int secondDigit = inputNumber%10;
            if (secondDigit == 0)
            {
                Console.WriteLine(twoDigitsToNinety[index]);
            }
            Console.WriteLine("{0} {1}", twoDigitsToNinety[firstDigitToIndex],
                                         oneDigit[secondDigit].ToLower());

        }
        if (inputNumber > 99)
        {
            string oneHundred = "hundred";

            int thirdIndex = inputNumber%10;

            int toSecondIndex = inputNumber/10;
            int secondDigit = toSecondIndex%10;
            int secondIndex = secondDigit - 2;

            int toFirstIndex = inputNumber/100;
            int firstIndex = toFirstIndex%10;

            if (secondDigit == 0 && thirdIndex == 0)
            {
                Console.WriteLine("{0} {1}", oneDigit[firstIndex], oneHundred);
            }

            else if (secondDigit == 1 && thirdIndex != 0)
            {
                Console.WriteLine("{0} {1} and {2}", oneDigit[firstIndex], oneHundred, 
                                                     twoDigitsToNineteen[thirdIndex].ToLower());
            }

            else if (secondDigit == 1 && thirdIndex == 0)
            {
                Console.WriteLine("{0} {1} and ten", oneDigit[firstIndex], oneHundred);
            }

            else if (secondDigit > 1 && thirdIndex != 0)
            {
                Console.WriteLine("{0} {1} and {2} {3}", oneDigit[firstIndex], oneHundred, 
                                                         twoDigitsToNinety[secondIndex].ToLower(), 
                                                         oneDigit[thirdIndex].ToLower());
            }
            else if (secondDigit > 1 && thirdIndex == 0)
            {
                Console.WriteLine("{0} {1} and {2}", oneDigit[firstIndex], oneHundred,
                                                    twoDigitsToNinety[secondIndex].ToLower());
            }
          
        }
    }
}


