using System;

// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("Write a number you want the sum of: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;

        for (double i = 1; i <= n; i++)
        {
            Console.Write("Write a number: ");
            double a = double.Parse(Console.ReadLine());
            sum += a;
        }

        Console.WriteLine("Sum: " + sum);
    }
}
