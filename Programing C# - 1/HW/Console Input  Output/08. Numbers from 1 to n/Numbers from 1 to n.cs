using System;

// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

class NumbersFrom1Ton
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(i);
        }
    }
}
