using System;

// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int numberToCheckBit = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter new bit value change (0 or 1): ");
        int bitNewValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position of bit to change: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << p;
        numberToCheckBit = bitNewValue == 1 ? numberToCheckBit | mask : numberToCheckBit ^ mask;

        Console.WriteLine(numberToCheckBit);
    }
}
