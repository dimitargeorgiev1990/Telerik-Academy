using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrological_Digits
{
    class Program
    {
        static void Main()
        {
            // Problem Astrological Digits
            string N = Console.ReadLine().Trim();
            do
            {
                string toString = N.ToString();
                long sum = 0;
                for (int i = 0; i < toString.Length; i++)
                {
                    if (char.IsDigit(toString[i]))
                    {
                        sum += int.Parse(toString[i].ToString());
                    }
                }
                N = sum.ToString();
            }
            while (N.Length > 1);

            Console.WriteLine(N);
        }
    }
}
