using System;

namespace Sand_Glass
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine().Trim());
            // first row 
            for (int i = 0; i < N; i++)
                Console.Write('*');
            Console.WriteLine();
            for (int i = 1; i < N - 1; i++)
            {
                if (i <= (N - 1) / 2)
                {
                    for (int j = 0; j < i; j++)
                        Console.Write('.');
                    for (int j = 0; j < N - i * 2; j++)
                        Console.Write('*');
                    for (int j = 0; j < i; j++)
                        Console.Write('.');
                }
                else
                {
                    for (int j = 0; j < N - i - 1; j++)
                    {
                        Console.Write('.');
                    }
                    for (int j = 0; j < N - (N - i - 1) * 2; j++)
                    {
                        Console.Write('*');
                    }
                    for (int j = 0; j < N - i - 1; j++)
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
            // last row 
            for (int i = 0; i < N; i++)
                Console.Write('*');
            Console.WriteLine();
        }
    }
}
