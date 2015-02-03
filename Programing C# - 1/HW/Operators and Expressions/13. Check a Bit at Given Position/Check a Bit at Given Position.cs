using System;

// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

class BitatGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int numberToCheckBit = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position of bit to check: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << p;
        numberToCheckBit &= mask;
        bool bitIsOne = numberToCheckBit > 0;
        Console.WriteLine("The bit at position {0} is 1? -> {1}", p, bitIsOne);
    }
}
