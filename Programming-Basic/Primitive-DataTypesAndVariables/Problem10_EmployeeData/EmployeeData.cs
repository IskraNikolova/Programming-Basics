
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// .First name
// .Last name
// .Age(0...100)
// .Gender(m or f)
// .Personal ID number(e.g. 8306112507)
// .Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive 
//data types.Use descriptive names.Print the data at the console.

using System;

public class EmployeeData
{
    public static void Main()
    {
        Console.WriteLine("Please write your first name");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please write your second name");
        string lastName = Console.ReadLine();

        int age = 0;
        do
        {
            Console.WriteLine("Please write age in range[0...100]!");
            age = int.Parse(Console.ReadLine());

        } while (age < 0 && age > 100);

        string gender = String.Empty;
        do
        {
            Console.WriteLine(@"Please write gender ""f"" or ""m""!");
            gender = Console.ReadLine();

        } while (!(gender == "f" || gender == "m"));

        Console.WriteLine("Please write your ID");
        string iD = Console.ReadLine();

        Console.WriteLine("Please write your Employee number");
        string employeeNumber = Console.ReadLine();

        //Formatting results
        string result = String.Format("\nFirst name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: " +
                       "{4}\nUnique Employee number: {5}", firstName, lastName, age, gender,iD, employeeNumber);

        Console.WriteLine(result);




    }
}

