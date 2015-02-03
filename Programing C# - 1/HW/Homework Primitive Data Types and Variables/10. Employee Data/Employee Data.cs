using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Stefan";
        string lastName = "Nikolov";
        byte age = 25;
        char gender = 'm';
        long personalID = 8123456789;
        int empNumber = 27560123;
    
        Console.WriteLine("First Name: " +firstName);
        Console.WriteLine("Last Name: " +lastName);
        Console.WriteLine(Convert.ToString ("Age: " + age));
        Console.WriteLine(Convert.ToString ("Gender: " + gender));
        Console.WriteLine(Convert.ToString ("Personal ID Number: " + personalID));
        Console.WriteLine(Convert.ToString ("Unique employee number: " + empNumber));
    }
}
