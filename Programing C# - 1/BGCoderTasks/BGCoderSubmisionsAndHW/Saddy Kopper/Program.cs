using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Saddy_Kopper
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger publicNumber = BigInteger.Parse(Console.ReadLine());
            string pubNumberStr = publicNumber.ToString();
            int evenNumbersSum = 0;
            int count = 0;
            BigInteger productOfSums = 1;
            bool isEnd = false;
            while (true)
            {
                count++;
                if (count == 10)
                {
                    Console.WriteLine(productOfSums);
                    return;
                }
                while (pubNumberStr.Length >= 1 && !isEnd)
                {
                    
                    publicNumber /= 10;
                    pubNumberStr = publicNumber.ToString();
                    

                    for (int j = 0; j < pubNumberStr.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            evenNumbersSum += int.Parse(pubNumberStr[j].ToString());
                        }
                    }
                    productOfSums *= evenNumbersSum;
                    evenNumbersSum = 0;
                }

                if (productOfSums <= 9)
                {
                    Console.WriteLine(count);
                    Console.WriteLine(productOfSums);
                    return;
                }

                publicNumber = productOfSums;
                
                productOfSums = 1;
                evenNumbersSum = 0;

                if (pubNumberStr.Length == 1)
                {
                    isEnd = true;
                }
            }
        }
    }
}
