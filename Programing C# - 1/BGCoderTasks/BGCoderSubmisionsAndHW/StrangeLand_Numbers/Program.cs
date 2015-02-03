using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLand_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictNumbers = new Dictionary<string, int>();
            dictNumbers.Add("f", 0);
            dictNumbers.Add("bIN", 1);
            dictNumbers.Add("oBJEC", 2);
            dictNumbers.Add("mNTRAVL", 3);
            dictNumbers.Add("lPVKNQ", 4);
            dictNumbers.Add("pNWE", 5);
            dictNumbers.Add("hT", 6);

            var sb = new StringBuilder(Console.ReadLine());
            string current = string.Empty;
            Stack<long> stackNumbers = new Stack<long>();
            for (int i = 0; i < sb.Length; i++)
            {
                current += sb[i];
                if (dictNumbers.ContainsKey(current))
                {
                    stackNumbers.Push(dictNumbers[current]);
                    sb.Remove(0, current.Length);
                    i = -1;
                    current = "";                   
                }
            }
            int numbersLength = stackNumbers.Count;
            long result = 0;
            for (int i = 0; i < numbersLength; i++)
            {
                result += (stackNumbers.Pop() * (long)Math.Pow(7, i ));
            }
            Console.WriteLine(result);
        }
    }
}
