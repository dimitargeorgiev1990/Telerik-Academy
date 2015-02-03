using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1.A__B_and_C_Description
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
            else if (a > c && b < c)
            {
                Console.WriteLine(a);
            }
            else if (a == b && b == c)
            {
                Console.WriteLine(a);
            }
            else if (a > b && b == c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && a == c)
            {
                Console.WriteLine(b);
            }
            else if (c > a && b == c)
            {
                Console.WriteLine(c);
            }
            else if (a == c && a > b)
            {
                Console.WriteLine(a);
            }
            else if (a == b && a > c)
            {
                Console.WriteLine(a);
            }
           
        }
    }
}
