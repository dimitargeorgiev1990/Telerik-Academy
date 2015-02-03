using System;

// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    // Use only one loop.

class CalculateNK
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
            long currentNFactoriel = 1;
            long currentKFactoriel = 1;

            for (int i = 1, j = 1; i <= n; i++, j++)
            {

                currentNFactoriel *= i;

                if (j <= k)
                    currentKFactoriel *= j;

            }
            Console.WriteLine(currentNFactoriel / currentKFactoriel);
        }
    }
}
