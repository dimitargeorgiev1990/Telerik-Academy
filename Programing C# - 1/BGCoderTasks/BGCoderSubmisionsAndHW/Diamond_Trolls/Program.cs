using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Trolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int height = 6 + ((N - 3) / 2 ) * 3;
            int width = N * 2 + 1;

            #region firstLine

            for (int j = 0; j < (width - N) / 2; j++)
            {
                Console.Write('.');
            }

            for (int j = 0; j < N; j++)
            {
                Console.Write('*');
            }
            for (int j = 0; j < (width - N) / 2; j++)
            {
                Console.Write('.');
            }

            #endregion;
            Console.WriteLine();
            for (int i = 0; i < height - 1; i++)
            {
                if (i + 1  < (height / 2 - 1))
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j + 1 ==  N - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                }
                else if (i + 1  == (height / 2 -1))
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write('*');
                    }
                }
                else
                {

                }
                Console.WriteLine();
            }
            // todo last line

            for (int i = 0; i < N; i++)
            {
                Console.Write('.');
            }
            Console.Write('*');
            for (int i = 0; i < N; i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}
