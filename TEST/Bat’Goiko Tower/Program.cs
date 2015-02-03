using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat_Goiko_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int countForPoints = 0, countForPointsExided = 0;
            char whatToWrite = '-';

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N * 2; j++)
                {
                    if (i != 0)
                    {
                       
                    }
                   
                    if (j == N - i - 1)
                        Console.Write("/");
                    else if (j == N + i )
                        Console.Write("\\");
                    else if (j > N - i - 1 && j < N + i && i != 0 )
                        Console.Write(whatToWrite);
                    else
                       Console.Write(".");
                          
                }
                if (countForPoints != countForPointsExided)
                {
                    whatToWrite = '.';
                    countForPointsExided++;
                }
                else
                {
                    whatToWrite = '-';
                    countForPoints++;
                    countForPointsExided = 0;
                }
                Console.WriteLine();
            }
        }
    }
}
