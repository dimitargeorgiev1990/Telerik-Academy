using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();

            string[] split = inputNumbers.Split(new Char[] { ',' });

            Console.WriteLine(inputNumbers);
        }
    }
}
