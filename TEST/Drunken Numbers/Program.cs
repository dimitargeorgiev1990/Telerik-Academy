using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Drunken_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int roundsCount = int.Parse(Console.ReadLine());

            long sumVladko = 0, sumMitko = 0;
            for (int i = 0; i < roundsCount; i++)
            {
                string currentRoundValue = Console.ReadLine().TrimStart('0','-');
                for (int j = 0; j < currentRoundValue.Length; j++)
                {
                    if (currentRoundValue.Length % 2 == 0) // example input = 12 34, 123 456
                    {
                        if (j <= currentRoundValue.Length / 2 - 1)
                            sumMitko += int.Parse(currentRoundValue[j].ToString());
                        else
                            sumVladko += int.Parse(currentRoundValue[j].ToString());
                    }
                    else// example input = 123, 12345
                    {
                        if (j <= currentRoundValue.Length / 2 - 1)
                            sumMitko+= int.Parse(currentRoundValue[j].ToString());
                        else if (j == currentRoundValue.Length / 2)
                        {
                            sumMitko += int.Parse(currentRoundValue[j].ToString());
                            sumVladko += int.Parse(currentRoundValue[j].ToString());
                        }
                        else
                            sumVladko += int.Parse(currentRoundValue[j].ToString());
                    }
                }
            }
            if (sumVladko > sumMitko)
            {
                Console.WriteLine("V " + (sumVladko - sumMitko));
            }
            else if (sumVladko < sumMitko)
            {
                Console.WriteLine("M " + (sumMitko - sumVladko));
            }
            else
            {
                Console.WriteLine("No " + (sumMitko + sumVladko));
            }
        }
    }
}
