using System;

// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

class Divideby7and5
{
    static void Main()
    {
        Console.WriteLine("Insert the n: ");
        int nToCheck = int.Parse(Console.ReadLine());
        bool test = (nToCheck % 5 == 0 && nToCheck % 7 == 0);
        Console.WriteLine(test);
    }
}
