using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter side 'a': ");
        float sideA = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter side 'b': ");
        float sideB = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter height 'h': ");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("Area: {0}", ((sideA + sideB) / 2) * height);
    }
}
