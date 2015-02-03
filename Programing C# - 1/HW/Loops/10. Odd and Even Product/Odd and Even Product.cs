using System;
using System.Linq;

// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter odd or even numbers separeted by space");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();

        int oddNumbersSum = 0;
        int evenNumbersSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            // check if its odd or even and add it to coresponding sum
        }

        Console.WriteLine(oddNumbersSum == evenNumbersSum);
    }
}
