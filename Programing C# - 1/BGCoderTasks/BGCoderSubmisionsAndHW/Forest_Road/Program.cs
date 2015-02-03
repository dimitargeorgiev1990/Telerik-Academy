using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest_Road
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int height = (2 * N) - 1;
            for (int i = 0; i <= N - 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i < N)
                    {
                        if (i == j)
                            Console.Write('*');
                        else
                            Console.Write('.');
                    }                
                }
                Console.WriteLine();
            }


            for (int i = N - 2; i >= 0; i--)
            {
                for (int j = 0; j < N; j++)
                {
                
                        if (i == j)
                            Console.Write('*');
                        else
                            Console.Write('.');
                    
                  

                }
                Console.WriteLine();
            }
        }
    }
}
