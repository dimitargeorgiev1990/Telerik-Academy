using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = Console.ReadLine();
            string secondLetter = Console.ReadLine();

            int numberOfLines = int.Parse(Console.ReadLine());
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int firstLetterCode = letters.IndexOf(firstLetter) + 1;
            int secoundLetterCode = letters.IndexOf(secondLetter) + 1;



            if (numberOfLines == 1)
            {
                Console.WriteLine(firstLetter);
            }
            else if (numberOfLines == 2)
            {
                int nextCode = firstLetterCode + secoundLetterCode;
                if (nextCode > 26)
                {
                    nextCode %= 26;
                }
                Console.WriteLine(firstLetter);
                Console.WriteLine(secondLetter + letters[nextCode - 1]);
            }
            else
            {
                int nextCode = firstLetterCode + secoundLetterCode;
                if (nextCode > 26)
                {
                    nextCode %= 26;
                }
                Console.WriteLine(firstLetter);
                Console.WriteLine(secondLetter + letters[nextCode - 1]);
                firstLetterCode = secoundLetterCode;
                secoundLetterCode = nextCode;
                for (int i = 2; i < numberOfLines; i++)
                {
                    nextCode = firstLetterCode + secoundLetterCode;
                    if (nextCode > 26)
                    {
                        nextCode %= 26;
                    }

                    // first
                    Console.Write(letters[nextCode - 1] + "");
                    firstLetterCode = secoundLetterCode;
                    secoundLetterCode = nextCode;

                    for (int j = -1; j < i - 2; j++)
                    {
                        Console.Write(" ");
                    }

                    nextCode = firstLetterCode + secoundLetterCode;

                    if (nextCode > 26)
                    {
                        nextCode %= 26;
                    }

                    Console.WriteLine(letters[nextCode - 1] + "");
                    firstLetterCode = secoundLetterCode;
                    secoundLetterCode = nextCode;
                }
            }
        }
    }
}
