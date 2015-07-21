
//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the 
//information for a single bank account using the appropriate data types and descriptive names.


using System;

public class BankAccountData
{
    public static void Main()
    {
        string firstName = "Iskra";
        string middleNme = "Radeva";
        string lastName = "Nikolova";

        decimal availableAmountOfMoney = 12345m;
        string bankName = "PostBank";
        string IBAN = "5656 7576 5762";
        string firstCreditCard = "768768769769";
        string secondCreditCard = "879867696999";
        string thirdCreditCard = "878789787879";

        Console.WriteLine("{0} {1} {2}\nBalance: {3}\nBank name: {4}\nIBAN: {5}\nFirst credit card: {6}" +
                      "\nSecond credit card: {7}\nThird credit card: {8}",firstName, middleNme, lastName, 
                     availableAmountOfMoney, bankName, IBAN, firstCreditCard, secondCreditCard, thirdCreditCard);
    }
}
