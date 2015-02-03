using System;

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter first variable: ");
        double firstVar = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second variable: ");
        double secondVar = double.Parse(Console.ReadLine());

        if (firstVar > secondVar)
        {
            double temp = firstVar;
            firstVar = secondVar;
            secondVar = temp;
        }
        Console.WriteLine("{0} {1}", firstVar, secondVar);
    }
}
