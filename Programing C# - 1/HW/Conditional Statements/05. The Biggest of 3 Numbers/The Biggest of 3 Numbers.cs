using System;

// Write a program that finds the biggest of three numbers.

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine("The biggest number is: " + firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine("The biggest number is: " + secondNumber);
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
        {
            Console.WriteLine("The biggest number is: " + thirdNumber);
        }
    }
}
