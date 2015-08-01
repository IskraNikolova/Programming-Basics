using System;

public class PrintCompanyInformation
{
    /// <summary>
    /// Write a program that reads the information about a company and its manager and prints 
    /// it back on the console.
    /// </summary>
    public static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",
                          companyName, companyAddress, phoneNumber, faxNumber,
                          webSite, managerFirstName, managerLastName, managerAge, managerPhone);

    }
}

