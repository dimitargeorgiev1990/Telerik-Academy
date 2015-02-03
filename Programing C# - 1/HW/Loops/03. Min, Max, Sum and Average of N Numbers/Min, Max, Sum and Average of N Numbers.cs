using System;

// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
  // The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
  // The output is like in the examples below.

class MinMaxSumandAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;
        int sum = 0;
        double average = 0;

        for (int i = 0; i < N; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;
            if (currentNumber <= minNumber)
            {
                minNumber = currentNumber;
            }
            if (currentNumber >= maxNumber)
            {
                maxNumber = currentNumber;
            }
        }
        Console.WriteLine("Min number: " + minNumber);
        Console.WriteLine("Max number: " + maxNumber);
        Console.WriteLine("Sum:" + sum);
        average = sum / N;
        Console.WriteLine("Average: {0:F2}", average);
    }
}
