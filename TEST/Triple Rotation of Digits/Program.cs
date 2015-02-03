using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Rotation_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberK = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
               
            if (numberK > 9)
            {
                int lastDigit = numberK % 10;
                numberK /= 10;

                string result = lastDigit.ToString() + numberK.ToString();

                numberK = int.Parse(result);
            }
 
            Console.WriteLine(numberK);
        }
    }
}
