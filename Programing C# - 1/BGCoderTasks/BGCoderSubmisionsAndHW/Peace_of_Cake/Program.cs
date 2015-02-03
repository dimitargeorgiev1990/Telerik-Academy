using System;
using System.Numerics;

class PoC
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long D = long.Parse(Console.ReadLine());
        long num = A * D + C * B;
        long denom = B * D;
        decimal result;

        if (num / denom != 0)
        {
            Console.WriteLine(num / denom);           
        }
        else
        {
            result = ((decimal)num / (decimal)denom);
            Console.WriteLine("{0:F22}", result);
        }
        Console.WriteLine(num + "/" + denom);
    }
}