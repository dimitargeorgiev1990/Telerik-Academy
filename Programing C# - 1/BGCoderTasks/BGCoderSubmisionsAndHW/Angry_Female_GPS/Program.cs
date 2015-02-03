using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Angry_Female_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger sumOdd = 0;
            BigInteger sumEven = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int current = int.Parse(input[i].ToString());
                    if (current % 2 == 0)
                        sumEven += current;
                    else
                        sumOdd += current;
                }
            }
            if (sumEven > sumOdd)
            {
                Console.WriteLine("right " + sumEven);
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("left " + sumOdd);
            }
            else
            {
                Console.WriteLine("straight " + sumOdd);
            }

        }
    }
}
