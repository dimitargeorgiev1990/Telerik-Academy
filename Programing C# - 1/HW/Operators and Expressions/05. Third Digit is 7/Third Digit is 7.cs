using System;

// Write an expression that checks for given integer if its third digit from right-to-left is 7.

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());

        n /= 100;

        bool thirdDigit = (n % 10) == 7;

        Console.WriteLine("The third digit is 7 ----> " + thirdDigit);
    }
}