using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peace_of_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            long denominatorBD = b * d;
            a *= d;
            c *= b;

            decimal fractionBoth = (a + c) / (decimal)denominatorBD;

            if (fractionBoth >= 1)
            {
                Console.WriteLine((long)fractionBoth);
            }
            else
            {
                Console.WriteLine("{0:F22}", Math.Round(fractionBoth, 22));
            }
            Console.WriteLine((a + c) + "/" + denominatorBD);
        }
    }
}
