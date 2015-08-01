
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange 
//their values by using some programming logic. Print the variable values before and after the exchange.

using System;

public class ExchangeVariableValues
{
    public static void Main()
    {
        int firstVariableToExchange = 5;
        int secondVariableToExchange = 10;
        int secondaryVariable = 0;

        string resultBefore = String.Format("a = {0}\nb = {1}", firstVariableToExchange, secondVariableToExchange);
        string messageBefore = "Before:";
        Console.WriteLine("{0}\n{1}", messageBefore, resultBefore);


        secondaryVariable = firstVariableToExchange;
        firstVariableToExchange = secondVariableToExchange;
        secondVariableToExchange = secondaryVariable;

        string resultAfter = String.Format("a = {0}\nb = {1}", firstVariableToExchange, secondVariableToExchange);
        string messageAfter = "After:";
        Console.WriteLine("{0}\n{1}", messageAfter, resultAfter);
    }
}

