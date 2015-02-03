using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmanation
{
    class Program
    {
        static StringBuilder input;
        static string[] stripedBrackets;


        static void Main()
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            input.Length--;
            stripedBrackets = input.ToString().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < stripedBrackets.Length; i++)
            {
                if (char.IsDigit(stripedBrackets[i][0]))
                {
                   stripedBrackets[i] = CalculateInBrackets(stripedBrackets[i]);
                }
                
               
            }
            Console.WriteLine(CalculateInBrackets(string.Join("", stripedBrackets)) + ".000");
        }

        static string CalculateInBrackets(string exp) 
        {
          
            int i=0, count=0;

            do
            {
                i++;
                count++;
            }
            while (char.IsDigit(exp[i]));
            int result = int.Parse(exp.Substring(0, count));
            for (int k = count; k < exp.Length - 1; k++)
            {
                switch (exp[k])
                {
                    case '+':
                        result += (int)Char.GetNumericValue(exp[k + 1]);
                        k++;
                        break;
                    case '*':
                        result *= (int)Char.GetNumericValue(exp[k + 1]);
                        k++;
                        break;
                    case '/':
                        result /= (int)Char.GetNumericValue(exp[k + 1]);
                        k++;
                        break;
                    case '-':
                        result -= (int)Char.GetNumericValue(exp[k + 1]);
                        k++;
                        break;
                    case '%':
                        result %= (int)Char.GetNumericValue(exp[k + 1]);          
                        k++;
                        break;
                    default:
                        break;
                }

            }
            return result.ToString();
        }
    }
}
