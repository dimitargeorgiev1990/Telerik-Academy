using System;

// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers you want between 'min' and 'max':");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ener 'min':");
        int minValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 'max':");
        int maxValue = int.Parse(Console.ReadLine());

        var random = new Random();

        if (minValue > maxValue)
        {
            Console.WriteLine("'min' should be < than 'max'");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(random.Next(minValue, maxValue + 1));   // max + 1 == max in .Next Mehod
            }
        }
    }
}