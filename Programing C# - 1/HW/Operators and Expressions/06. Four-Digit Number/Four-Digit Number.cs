﻿using System;

// Write a program that takes as input a four-digit n in format abcd (e.g. 2011) and performs the following:
//        -Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        -Prints on the console the n in reversed order: dcba (in our example 1102).
//        -Puts the last digit in the first position: dabc (in our example 1201).
//        -Exchanges the second and the third digits: acbd (in our example 2101).
//
// The n has always exactly 4 digits and cannot start with 0.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the 4-digit n: ");
        string input = Console.ReadLine();

        int n;
        bool isn = int.TryParse(input, out n);
        if (isn && input.Length == 4)
        {
            int currentn = n;
            int firstDigit = currentn / 1000;
            int secondDigit = (currentn / 100) % 10;
            int thirdDigit = (currentn / 10) % 10;
            int fourDigit = currentn % 10;
            int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourDigit;
            string reverseDigit = fourDigit.ToString() + thirdDigit + secondDigit + firstDigit;
            string firstExchange = fourDigit.ToString() + firstDigit + secondDigit + thirdDigit;
            string secondExchange = firstDigit.ToString() + thirdDigit + secondDigit + fourDigit;

            Console.WriteLine("Sum of digits: {0}", sumOfDigits);
            Console.WriteLine("Reverse digit: {0}", reverseDigit);
            Console.WriteLine(firstExchange);
            Console.WriteLine(secondExchange);
        }
        else
        {
            Console.WriteLine("Input string was not in a correct format");
        }
    }
}