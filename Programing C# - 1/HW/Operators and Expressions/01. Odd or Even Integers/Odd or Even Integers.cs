using System;

// Write an expression that checks if given integer is odd or even.

class OddorEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Insert n to check: ");
        int n = int.Parse(Console.ReadLine());
        bool test = (n % 2) != 0;
        Console.WriteLine("Odd? {0}", test);
    }
}
