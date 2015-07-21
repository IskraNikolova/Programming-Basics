
//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two variables 
//(mind adding an interval between). Declare a third string variable and initialize it with the value 
//of the object variable (you should perform type casting).


using System;
using System.Text;

public class StringAndObjects

{
    public static void Main()
    {
        string hello = "Hello";
        string intervalBetween = " ";
        string world = "World";

        StringBuilder concatenation = new StringBuilder();
        concatenation.Append(hello);
        concatenation.Append(intervalBetween);
        concatenation.Append(world);

        string resultOfConcatenation = concatenation.ToString();
        Console.WriteLine(resultOfConcatenation);
    }
}

