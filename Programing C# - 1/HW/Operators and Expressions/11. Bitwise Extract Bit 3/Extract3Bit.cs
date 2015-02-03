using System;

/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

class Extract3Bit
{
    static void Main()
    {
        Console.WriteLine("Enter intto check what is the third bit: ");
        uint num = uint.Parse(Console.ReadLine());
        uint check = num & 8;
        Console.WriteLine(check > 0 ? "The third bit is: 1" : "The third bit is: 0");
    }
}
