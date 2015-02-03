using System;

// ite a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient 'a': ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient 'b': ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient 'c': ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - (4 * a * c);

        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
            return;
        }
        if (discriminant == 0)
        {
            double root3 = (-b / 2 * a);
            Console.WriteLine("x1 = x2 = " + root3);
        }
        else
        {
            double root1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
            double root2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
            Console.WriteLine("x1: {0} ; x2: {1}", root1, root2);
        }
    }
}
