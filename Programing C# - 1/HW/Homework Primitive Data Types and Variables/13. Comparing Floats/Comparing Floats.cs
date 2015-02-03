using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first number to compare");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number to compare");
        double secondNumber = double.Parse(Console.ReadLine());
        double compare = Math.Abs(firstNumber - secondNumber);
        double eps = 0.000001;
        if (compare <= eps)
        {
            Console.WriteLine("equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}