using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long evenSum = 0;
            long oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentDigit = input[i];
                if (!char.IsDigit(currentDigit))
                {
                    continue;
                }

                long aDigit = long.Parse(currentDigit.ToString());

                if (aDigit % 2 == 0)
                {
                    evenSum = evenSum + aDigit;
                }
                else
                {
                    oddSum = oddSum + aDigit;
                }
            }
            if (evenSum > oddSum)
            {
                Console.WriteLine("right " + evenSum);    
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("left " + oddSum);    
            }
            else
            {
                Console.WriteLine("straight " + oddSum);
            }

        }
    }
}
