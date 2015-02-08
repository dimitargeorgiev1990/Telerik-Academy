using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torti
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);
            int cakes;

            if (n >= 0 && n <= 1000)
            {
                if (m >= 1 && m <= 1000)
                {
                    if (n % m == 0)
                    {
                        cakes = n / m;
                        Console.WriteLine(cakes);
                    }
                    else
                    {
                        cakes = (n / m) + 1;
                        Console.WriteLine(cakes);
                    }
                }
                else
                    Console.WriteLine("Please enter a number of parts betwean 1 and 1000");
            }
            else
                Console.WriteLine("Please enter a number of children betwean 0 and 1000");
        }
    }
}
