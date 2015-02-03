using System;

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PoitInCircleRectangle
{
    static void Main()
    {
        // read input
        // podouble
        Console.WriteLine("Enter x of the point?");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter  y of the point?");
        double y = double.Parse(Console.ReadLine());
        // rectangle
        Console.WriteLine("Enter x of the left top edge of the rectangle");
        double xStartRect = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter y of the left top edge of the rectangle");
        double yStartRect = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter width of rect");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height of rect");
        double height = double.Parse(Console.ReadLine());
        // circle
        Console.WriteLine("Enter x for circle");
        double xCircle = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter y for circle");
        double yCircle = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter circle radius");
        double radius = double.Parse(Console.ReadLine());


        // solve circle

        bool isInCircle = (Math.Pow(x, 2) - xCircle) + (Math.Pow(y, 2) - yCircle) <= radius * radius;

        // solve rectangle
        bool isInRectangle = x > xStartRect && x < width - xStartRect && y < yStartRect && y > height - yStartRect;

        // prdouble results
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("The point is inside circle and outside rectangle -> {0}", isInCircle && !isInRectangle);
        Console.WriteLine("------------------------------------------------------------------------");
    }
}