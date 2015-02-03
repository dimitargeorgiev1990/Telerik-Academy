using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Excel_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] letters = new char[n];
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                letters[i] = char.Parse(Console.ReadLine());
                sum *= 26;
                sum += (long)(letters[i] - 'A' + 1);
            }
            Console.WriteLine(sum);
        }
    }
}
