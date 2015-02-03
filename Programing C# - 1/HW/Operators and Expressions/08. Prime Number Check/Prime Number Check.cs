using System;

// Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 100)
        {
            Console.WriteLine("The number is in invalid range.");
            return;
        }
        bool isPrime = true;
        if (n >= 1)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
