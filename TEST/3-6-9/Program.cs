using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long result;

            if (b == 3)
            {
                result = a + c;
            }
            else if (b == 6)
            {
                result = a * c;
            }
            else
            {
                result = a % c;
            }

            if (result % 3 == 0)
            {
                Console.WriteLine(result / 3);
            }
            else
            {
                Console.WriteLine(result % 3);
            }
            Console.WriteLine(result);
        }
    }
}
