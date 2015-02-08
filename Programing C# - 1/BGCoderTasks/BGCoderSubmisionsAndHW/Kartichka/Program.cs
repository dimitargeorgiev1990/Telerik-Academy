using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartichka
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);

            if ((a >= 0) && (a <= 9))
            {
                if ((b >= 0) && (b <= 9))
                {
                    Console.WriteLine("  #*#");
                    Console.WriteLine("  ***");
                    Console.WriteLine("  #*#");
                    Console.WriteLine("   {0}", b);
                    Console.WriteLine("{0}  {1}  {0}", a, b);
                    Console.WriteLine(" {0} {1} {0}", a, b);
                    Console.WriteLine("  {0}{1}{0}", a, b);
                }
                else
                    Console.WriteLine("Enter a number for the stable between 0 and 9.");
            }
            else
                Console.WriteLine("ENTER a number for the leafs between 0 and 9.");
        }
    }
}
