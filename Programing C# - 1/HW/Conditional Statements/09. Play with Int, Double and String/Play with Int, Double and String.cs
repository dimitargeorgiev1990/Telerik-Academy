using System;

/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose type \n1 ---> int \n2 ---> double \n3 ---> string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Please enter integer: ");
                int intVar = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(intVar);
                break;
            case "2":
                Console.WriteLine("Please enter double: ");
                double doubleVar = double.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(doubleVar);
                break;
            case "3":
                Console.WriteLine("Please enter string: ");
                string strVar = Console.ReadLine() + "*";
                Console.WriteLine(strVar);
                break;
            default:
                Console.WriteLine("wrong ichoice");
                break;
        }     
    }
}
