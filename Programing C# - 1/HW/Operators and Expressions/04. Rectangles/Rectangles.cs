using System;

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width: ");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter: {0}",  (2*width) + (2*height));
        Console.WriteLine("Area: {0}", width*height);
    }
}
