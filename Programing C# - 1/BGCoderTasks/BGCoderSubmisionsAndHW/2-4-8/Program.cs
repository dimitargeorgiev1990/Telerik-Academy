using System;
using System.Numerics;

namespace _2_4_8
{
    class Program
    {
        static void Main()
        {
            BigInteger r = 0;
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());

            if (b == 2)
            {
                r = a % c;
            }
            else if (b == 4)
            {
                r = a + c;
            }
            else if (b == 8)
            {
                r = a * c;
            }

            if (r % 4 == 0)
            {
                Console.WriteLine(r / 4);
            }
            else
            {
                Console.WriteLine(r % 4);
            }
            Console.WriteLine(r);
        }
    }
}
