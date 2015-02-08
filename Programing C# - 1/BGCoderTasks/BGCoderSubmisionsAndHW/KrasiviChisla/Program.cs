using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrasiviChisla
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            bool isNiceNumber = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    int currentDiggit = int.Parse(number[i].ToString());
                    int rightDiggitsSum = 0;
                    for (int j = i + 1; j < number.Length; j++)
                    {
                        rightDiggitsSum += int.Parse(number[j].ToString());
                    }
                    if (currentDiggit < rightDiggitsSum)
                    {
                        isNiceNumber = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isNiceNumber ? "YES" : "NO");
        }
    }
}
