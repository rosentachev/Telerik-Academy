using System;

class CompanyAndManagerInfo
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager. 
        //The manager has first name, last name, age and a phone number. 
        //Write a program that reads the information about a company and its manager and prints them on the console.

        Console.Write("Please enter company name -> ");
        string companyName = Console.ReadLine();
        Console.Write("Please enter company address -> ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please enter company phone number -> ");
        string companyPhone = Console.ReadLine();
        Console.Write("Please enter company fax number -> ");
        string companyFax = Console.ReadLine();
        Console.Write("Please enter company Web Site -> ");
        string companySite = Console.ReadLine();
        Console.Write("Please enter manager first name -> ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Please enter manager last name -> ");
        string managerLastName = Console.ReadLine();
        Console.Write("Please enter manager age -> ");
        string managerAge = Console.ReadLine();
        Console.Write("Please enter manager phone number -> ");
        string managerNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("-----Information About Company-----");
        Console.WriteLine("Company name - {0}", companyName);
        Console.WriteLine("Company adress - {0}", companyAddress);
        Console.WriteLine("Company phone number - {0}", companyPhone);
        Console.WriteLine("Company fax number - {0}", companyFax);
        Console.WriteLine("Company Web Site - {0}", companySite);
        Console.WriteLine("-----Information About Company Manager-----");
        Console.WriteLine("Manager first name - {0}", managerFirstName);
        Console.WriteLine("Manager last name - {0}", managerLastName);
        Console.WriteLine("Manager age - {0}", managerAge);
        Console.WriteLine("Manager phone number - {0}", managerNumber);
    }
}