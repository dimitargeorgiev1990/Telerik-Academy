using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace The_Horror
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long sum = 0;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) && i % 2 == 0)
                {
                 counter++;
                 sum += int.Parse(input[i].ToString());
                }
            }
            Console.WriteLine(counter + " " + sum);
        }
    }
}
