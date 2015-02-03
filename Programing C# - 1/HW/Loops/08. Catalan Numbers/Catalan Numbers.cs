using System;
using System.Numerics;

// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            long fakt2n = 1;
            long faktn1 = 1;

            if (n < 0 || n > 100)
            {
                Console.WriteLine("Please enter a number bigger than 0 and smaller than 101");
                return;
            }
            else
            {
                // validate input
                if (n == 0)
                {
                    Console.WriteLine("The 0 Catalan number is: 1");
                    return;
                }

                // calculate 2*n !
                for (int i = 1; i <= (2 * n); i++)
                {
                    fakt2n *= i;
                }
                
                // calculate (n + 1)!
                for (int i = 1; i <= (n + 1); i++)
                {
                    faktn1 *= i;
                }

                // calculate n!
                long faktnFormula = faktn1 / (n + 1);

                // print results
                Console.WriteLine("The [{0}] Catalan number is: {1}", n, fakt2n / (faktn1 * faktnFormula));
            }
        }
}