using System;

// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

class CirclePerimeterandArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Peremeter: {0:F2}", Math.PI * 2 * radius);
        Console.WriteLine("Area: {0:F2} ", Math.PI * radius * radius);   
     }
}
