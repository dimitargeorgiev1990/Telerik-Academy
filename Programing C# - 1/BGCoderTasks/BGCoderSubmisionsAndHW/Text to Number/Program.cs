using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Text_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int i = 0;
            int result = 0;

            while (text[i] != '@')
            {
                if (char.IsDigit(text[i]))
                {
                    result *= int.Parse(text[i].ToString());
                }
                else if (char.IsLetter(text[i]))
                {
                    if (char.IsUpper(text[i]))
                    {
                         result += ((int)text[i] - 65);
                    }
                    else
                    {
                        result += (int)text[i] - 97;
                    }
                }
                else
                {
                    result %= M;
                }
                i++;    
            }
            Console.WriteLine(result);
        }
    }
}
