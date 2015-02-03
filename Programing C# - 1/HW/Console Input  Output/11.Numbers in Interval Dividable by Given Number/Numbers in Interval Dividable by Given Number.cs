using System;

// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Insert min range value");
        uint min = uint.Parse(Console.ReadLine());

        Console.WriteLine("Insert max range value");
        uint max = uint.Parse(Console.ReadLine());

        uint p = 0;
        for (uint i = min; i <= max; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("Count of numbers in range: {0}-{1} that are devisable by 5 is: {2}", min, max, p);
    }
}
