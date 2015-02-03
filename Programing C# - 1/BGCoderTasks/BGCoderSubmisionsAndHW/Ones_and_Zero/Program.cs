using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ones_and_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int absn = Math.Abs(n);

            string binary = Convert.ToString(n, 2);
            while (binary.Length < 16)
            {
               binary = binary.Insert(0, "0");
            }
            binary = binary.Substring(binary.Length - 16, 16);
            
            int indexOfBit = 0;

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 63; col++)
                {
                    indexOfBit = col / 4;
                    if (binary[indexOfBit] == '0')
                    {
                        if (row == 0 || row == 4)
                        {
                            col += 3;
                            Console.Write('#');
                            Console.Write('#');
                            Console.Write('#');
                        }
                        else
                        {
                            col += 3;
                            Console.Write('#');
                            Console.Write('.');
                            Console.Write('#');
                        }
                        
                    }
                    else // the diggit is 1
                    {
                        if (row == 1)
                        {
                            col += 3;
                            Console.Write('#');
                            Console.Write('#');
                            Console.Write('.');
                        }
                        else if (row == 4)
                        {
                            col += 3;
                            Console.Write('#');
                            Console.Write('#');
                            Console.Write('#');
                        }
                        else
                        {
                            col += 3;
                            Console.Write('.');
                            Console.Write('#');
                            Console.Write('.');
                        }
                    }
                    if (col < 61)
                        Console.Write('.');
                }
                Console.WriteLine(); // new row
                
            }
        }
    }
}
