using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukviICifri
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int countLowerLetter = 0;
            int countDigit = 0;
            int countUpperLetter = 0;
            int countSymbol = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    countDigit++;
                }
                else if (char.IsLetter(text[i]))
                {
                    if (char.IsUpper(text[i]))
                    {
                        countUpperLetter++;
                    }
                    else if (char.IsLower(text[i]))
                    {
                        countLowerLetter++;
                    }
                }
                else
                {
                    countSymbol++;
                }
            }
            Console.WriteLine("{0} {1} {2} {3}", countDigit, countLowerLetter, countUpperLetter, countSymbol);
        }
    }
}
