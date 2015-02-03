using System;

/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter Company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter Company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter Company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("Enter Fax: ");
        int fax = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter web address: ");
        string web = Console.ReadLine();
        Console.WriteLine("Enter Manager's first and last name: ");
        string managerNames = Console.ReadLine();
        Console.WriteLine("Enter Manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter Manager's phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("Company name: {0}" + "\nCompany address: {1}" + "\nCompany phone number: {2}" + "\nCompany fax: {3}" + "\nWeb address: {4}", companyName,companyAddress,companyPhone,fax,web);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerNames, managerAge, managerPhone);
    }
}
