using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger A = BigInteger.Parse(Console.ReadLine());
            BigInteger B = BigInteger.Parse(Console.ReadLine());
            BigInteger C = BigInteger.Parse(Console.ReadLine());

            BigInteger result = 0;
            if (B == 3)
            {
                result = A + C;
            }
            else if (B == 6)
            {
                result = A * C;
            }
            else if (B == 9)
            {
                result = A % C;
            }

            if (result % 3 == 0)
                Console.WriteLine(result / 3);
            else
                Console.WriteLine(result % 3);
            Console.WriteLine(result);
        }
    }
}
