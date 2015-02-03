using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    // Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter 'a': ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 'b': ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 'c': ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber ==0)
        {
            Console.WriteLine("The sign is: 0");
        }
        else
        {
           if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                Console.WriteLine("The sign is: -");
            }
           else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
           {
               Console.WriteLine("The sign is: +");
           }
           else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
           {
               Console.WriteLine("The sign is: -");
           }
           else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
           {
               Console.WriteLine("The sign is: +");
           }
           else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
           {
               Console.WriteLine("The sign is: -");
           }
           else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
           {
               Console.WriteLine("The sign is: -");
           }
           else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
           {
               Console.WriteLine("The sign is: +");
           }
           else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
           {
               Console.WriteLine("The sign is: +");
           }
        }
    }
}
