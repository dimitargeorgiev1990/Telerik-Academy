using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(GetmNumberOfSubsets(input, s));
        }

        private static int GetmNumberOfSubsets(int[] numbers, int sum)
        {
            int[] dp = new int[sum + 1];
            dp[0] = 1;
            int currentSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum += numbers[i];
                for (int j = Math.Min(sum, currentSum); j >= numbers[i]; j--)
                    dp[j] += dp[j - numbers[i]];
            }

            return dp[sum];
        }
    }
}
