using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            char searched = Console.ReadLine().Trim()[0];
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string binaryNumber = Convert.ToString(long.Parse(Console.ReadLine()), 2);
                Console.WriteLine(binaryNumber.Where(x=>x == searched).Count());
            }
        }
    }
}
