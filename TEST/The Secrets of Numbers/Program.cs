using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace The_Secrets_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int digitPosition = 1;
            long secretSum = 0;
                                                       
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(input[i]))
                {
                    continue;
                }
                int currentDigit = int.Parse(input[i].ToString());

                if (digitPosition % 2 == 0)
                {
                    secretSum += (long)Math.Pow(currentDigit, 2) * digitPosition;
                }
                else 
                {
                    secretSum += currentDigit * (long)Math.Pow(digitPosition, 2);
                }
                digitPosition++;
            }
            Console.WriteLine(secretSum);

            long R = secretSum % 26;
            long lastDigit = secretSum % 10;
            string alphaSequence = "";

            if (lastDigit == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", input);
            }
            else
            {
                
                long count = R + 1 + 64;

                for (int i = 1; i <= lastDigit; i++)
                {
                   
                   if (count  > 90)
                   {
                       count = 65;
                   }
                   alphaSequence += (char)count; 
                   count++;

                }
                Console.WriteLine(alphaSequence);
            }
        }
    }
}
