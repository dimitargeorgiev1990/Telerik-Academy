using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.A__B_and_C
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal num3 = decimal.Parse(Console.ReadLine());

            decimal[] numbers = { num1, num2, num3 };
            decimal lowest = numbers.Min();

            decimal highest = numbers.Max();
            Console.WriteLine(highest);
            Console.WriteLine(lowest);

            decimal sum2 = ((decimal)num1 + (decimal)num2 + (decimal)num3) / 3;

            Console.WriteLine("{0:F3}", sum2);
        }
    }
}
