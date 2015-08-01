
//Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console. Try to add some number or the null literal
//to these variables and print the result.

using System;

public class NullValuesArithmetic
{
    public static void Main()
    {
        int? nullIntValue = null;
        double? nullDoubleValue = null;

        Console.WriteLine("-{0}-\n-{1}-", nullIntValue, nullDoubleValue);

        nullIntValue = 0;
        nullDoubleValue = 1.2;

        Console.WriteLine("{0}\n{1}", nullIntValue, nullDoubleValue);
    }
}

