using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapla6taneZaInternet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int monthTax = int.Parse(input[0]);
            int mbTrafic = int.Parse(input[1]);
            int priceForOneMBOverTheTrafic = int.Parse(input[2]);
            int mbByLoni = int.Parse(input[3]);

            if (mbByLoni <= mbTrafic)
            {
                Console.WriteLine(monthTax);
            }
            else
            {
                Console.WriteLine(monthTax + ( (mbByLoni - mbTrafic) * priceForOneMBOverTheTrafic));
            }
        }
    }
}
