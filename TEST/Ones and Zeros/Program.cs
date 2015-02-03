using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ones_and_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get values from this string.
            string value = "Dot Net Perls";
            char first = value[0];
            char second = value[1];
            char last = value[value.Length - 1];

            // Write chars.
            Console.WriteLine("--- 'Dot Net Perls' ---");
            Console.Write("First char: ");
            Console.WriteLine(first);
            Console.Write("Second char: ");
            Console.WriteLine(second);
            Console.Write("Last char: ");
            Console.WriteLine(last);
        }
    }
}
