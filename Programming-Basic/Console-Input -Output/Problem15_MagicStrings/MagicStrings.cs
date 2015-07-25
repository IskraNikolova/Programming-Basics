using System;

public class MagicStrings
{
    public static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };

        int resultsCount = 0;
        for (int index1 = 0; index1 < letters.Length; index1++)
        {
            for (int index2 = 0; index2 < letters.Length; index2++)
            {
                for (int index3 = 0; index3 < letters.Length; index3++)
                {
                    for (int index4 = 0; index4 < letters.Length; index4++)
                    {
                        string leftResult = "" + letters[index1] + letters[index2]
                                               + letters[index3] + letters[index4];

                        int leftSum = CalculateSumOfDigit(leftResult);

                        for (int rightIndex1 = 0; rightIndex1 < letters.Length; rightIndex1++)
                        {
                            for (int rightIndex2 = 0; rightIndex2 < letters.Length; rightIndex2++)
                            {
                                for (int rightIndex3 = 0; rightIndex3 < letters.Length; rightIndex3++)
                                {
                                    for (int rightIndex4 = 0; rightIndex4 < letters.Length; rightIndex4++)
                                    {
                                        string rightResult = "" + letters[rightIndex1] + letters[rightIndex2]
                                                                + letters[rightIndex3] + letters[rightIndex4];

                                        int rightSum = CalculateSumOfDigit(rightResult);

                                        if (Math.Abs(leftSum - rightSum) == diff)
                                        {
                                            Console.WriteLine(leftResult + rightResult);
                                            resultsCount++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateSumOfDigit(string result)
    {
        int sumOfDigit = 0;
        foreach (var chars in result)
        {
            switch (chars)
            {
                case 's': sumOfDigit += 3; break;
                case 'n': sumOfDigit += 4; break;
                case 'k': sumOfDigit += 1; break;
                case 'p': sumOfDigit += 5; break;
            }
        }
        return sumOfDigit;
    }
}

