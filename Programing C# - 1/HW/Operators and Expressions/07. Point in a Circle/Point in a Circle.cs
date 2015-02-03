using System;

// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

class PointInaCircle
{
    static void Main()
    {
        double radius = 2;
        double area = Math.PI * Math.Sqrt(radius);
        Console.WriteLine("Enter a value for 'x': ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for 'y': ");
        double y = double.Parse(Console.ReadLine());
        string msg = (x * x + y * y) <= radius * radius ? "The point is inside the Circle" : "The point is not in the Circle";
        Console.WriteLine(msg);
    }
}