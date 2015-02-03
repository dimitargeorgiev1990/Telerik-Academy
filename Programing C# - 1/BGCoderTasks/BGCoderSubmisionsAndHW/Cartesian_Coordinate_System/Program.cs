using System;
using System.Numerics;

namespace Cartesian_Coordinate_System
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine().Trim());
            double y = double.Parse(Console.ReadLine().Trim());
             if (x == 0 && y == 0)
                    Console.WriteLine(0);
             else if (x == 0 && y > 0)
                 Console.WriteLine(5);            
            else if (x >  0 && y > 0)
                    Console.WriteLine(1);
             else if (x > 0 && y < 0)
                 Console.WriteLine(4);
             else if (x < 0 && y < 0)
                 Console.WriteLine(3);
            else if (x < 0 && y > 0)
                    Console.WriteLine(2);
            else 
                    Console.WriteLine(6);
        }
    }
}
