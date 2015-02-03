using System;

namespace Problem_2___Symbol_to_Number
{
    class Program
    {
        static void Main()
        {
            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            // iterate characters
            int i = 0;
            string encodedValue = "";

            while (text[i] != '@')
            {
                if (char.IsLetter(text[i]))
                    encodedValue += (char)((text[i] * secret) + 1000);
                else if (char.IsDigit(text[i]))
                    encodedValue += (char)((text[i] + secret) + 500);
                else
                    encodedValue += (char)(text[i] - secret);

                if (i % 2 == 0)
                    Console.WriteLine("{0:F2}", (encodedValue[i] / (double)100));
                else
                    Console.WriteLine(encodedValue[i] * 100);

                i++;
            }
        }
    }
}