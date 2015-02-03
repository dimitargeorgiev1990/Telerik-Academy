﻿using System;

// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    // Use only one loop. Print the result with 5 digits after the decimal point.

class Calculate1dgd
{
    static void Main()
    {
        Console.WriteLine("Enter 'n':");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 'x':");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        long currentFacturel = 1;

        for (int i = 1; i <= n; i++)
        {
            currentFacturel *= i;
            sum += (decimal)(currentFacturel / Math.Pow(x, i));
        }

        Console.WriteLine("sum {0:F5}", sum);        
    }
}
