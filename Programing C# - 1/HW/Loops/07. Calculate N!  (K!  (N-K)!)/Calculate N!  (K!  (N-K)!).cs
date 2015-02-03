using System;
using System.Numerics;

// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

class CalculateNKNK
{
    static void Main()
    {
        Console.WriteLine("Enter 'n' > 1, > 'k' and < 100:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 'k' > 1 and < 100:");
        int k = int.Parse(Console.ReadLine());

        if (k < 1 || k > 100 || n < 1 || n > 100 || n <= k)
        {
            Console.WriteLine("wrong input");
        }
        else
        {
            BigInteger currentKFactoriel = 1;
            BigInteger currentNFactoriel = 1;
            BigInteger currentNMinusKFackt = 1;

            for (BigInteger i = 1, j = 1, nk = 1; i <= n; i++, j++, nk++)
            {
                currentNFactoriel *= i;

                if (j <= k)
                    currentKFactoriel *= j;

                if (nk <= n - k)
                    currentNMinusKFackt *= nk;

            }
            Console.WriteLine("n! / (k! * (n - k)!) = {0}", currentNFactoriel / (currentKFactoriel * currentNMinusKFackt));
        }
    }
}
