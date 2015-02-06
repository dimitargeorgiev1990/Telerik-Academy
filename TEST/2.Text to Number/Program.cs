using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Text_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int i = 0;
            string encodedValue = "";

            while (text[i] != '@')
            {
                double result = 0;
                double totalResult = 0;

                if (char.IsDigit(text[i]))
                {
                    encodedValue += (text[i] * result);
                    totalResult++;
                }
                else if (char.IsLetter(text[i]))
                {
                    encodedValue += (text[i] + result);
                    totalResult++;
                }
                else
                {
                    encodedValue += result % secret;

                    i++;
                    Console.WriteLine(totalResult);

                   
                }
               
            }
        }
    }
}
