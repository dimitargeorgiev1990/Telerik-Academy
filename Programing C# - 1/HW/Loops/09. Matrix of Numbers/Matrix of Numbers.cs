using System;

// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
    // Use two nested loops.

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter positiv integer number 'n':  1<=n<=20 --->");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 20)
        {
            Console.WriteLine("wrong input");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(((j + i) + " ").PadLeft(n.ToString().Length + 1, '0'));
                }
                Console.WriteLine();
            }
        }
    }
}
