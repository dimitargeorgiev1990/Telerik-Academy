using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miss_Cat_2011
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] catsVotes = new int[10];
            for (int i = 0; i < n; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                catsVotes[vote - 1]++;
            }
            int mostVotes = catsVotes.Max();
            Console.WriteLine(catsVotes.ToList().IndexOf(mostVotes) + 1);
        }
    }
}
