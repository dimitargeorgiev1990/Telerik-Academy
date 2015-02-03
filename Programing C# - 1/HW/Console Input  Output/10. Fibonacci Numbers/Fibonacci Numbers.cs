using System;

// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

class FibonacciNumbers
{
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
       
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            Console.Write("{0}, ",Fibonacci(i));
        }
    }
}