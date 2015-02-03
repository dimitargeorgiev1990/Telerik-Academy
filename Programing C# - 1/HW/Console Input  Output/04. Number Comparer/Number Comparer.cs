using System;

// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter 'a': ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 'b': ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The Greater is:{0}", firstNumber > secondNumber ? firstNumber : secondNumber);
    }
}
