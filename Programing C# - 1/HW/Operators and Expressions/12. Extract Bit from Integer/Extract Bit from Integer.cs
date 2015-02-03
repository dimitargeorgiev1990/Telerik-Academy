using System;

// Write an expression that extracts from given integer n the value of given bit at index p.

class Program
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
        Console.WriteLine(numberToCheckBit > 0 ? "The bit is: 1" : "The bit is: 0");
    }
}
