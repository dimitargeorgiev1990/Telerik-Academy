using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nightmare_on_Code_Street
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counter = 0;
            long sum = 0;
                
            
            for (int i = 0; i < input.Length; i++)
            {

                if (char.IsDigit(input[i]) && i % 2 != 0)
                {
                    counter++;
                    sum += int.Parse(input[i].ToString());
                }
            }
            Console.WriteLine(counter + " " + sum);
        }
    }
}
