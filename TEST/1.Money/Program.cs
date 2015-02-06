using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Printing
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            decimal R = 400;
            decimal totalSheets = N * S;
            decimal rearms = totalSheets / R;

            decimal finalSum = rearms * P;

            Console.WriteLine("{0:F3}", finalSum);
        }
    }
}