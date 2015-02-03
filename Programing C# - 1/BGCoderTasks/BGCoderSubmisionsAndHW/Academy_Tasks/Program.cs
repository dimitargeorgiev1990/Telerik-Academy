using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_Tasks
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            int value = int.Parse(Console.ReadLine().Trim());
            int count = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                min = Math.Min(min, numbers[i]);
                max = Math.Max(max, numbers[i]);           

                if (max - min >= value)
                {
                    maxIndex = i;
                    break;
                }
            }
            Console.WriteLine(count + 1);
        }
    }
}
