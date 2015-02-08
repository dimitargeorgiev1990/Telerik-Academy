using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaryci
{
    class Program
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split();
            int m = int.Parse(tokens[0]);
            int c = int.Parse(tokens[1]);
            int k = int.Parse(tokens[2]);

            int cqla = m * k;
            int drobna = c * k;

            int cqladrobna = drobna / 100;
            int drobnadrobna = drobna % 100;

            cqla = cqla + cqladrobna;
            drobna = drobnadrobna;

            Console.WriteLine("{0} {1}", cqla, drobna);
        }
    }
}
