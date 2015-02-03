using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Girls_One_Path
{
    class Program
    {
        static void Main()
        {
            // todo: indexes sum or not sum

            int mollyForwardFlowers = 0;
            int dollyBackwardFlowers = 0;
            int mollyIndex = 0;
            int dollyIndex = 0;

            int[] path = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            dollyIndex = path.Length - 1;
            while (path[mollyIndex] > 0 && path[dollyIndex] > 0)
            {
                if (mollyIndex >= path.Length)
                    mollyIndex = 0;
                if (dollyIndex < 0)
                    dollyIndex = path.Length - 1;

                if (dollyIndex != mollyIndex)
                {
                    mollyForwardFlowers += path[mollyIndex];
                    dollyBackwardFlowers += path[dollyIndex];
                    mollyIndex +=  path[mollyIndex] % path.Length;
                    dollyIndex -= path[dollyIndex] % path.Length;
                }
                else
                {
                    mollyIndex += path[mollyIndex] % path.Length;
                    dollyIndex -= path[dollyIndex] % path.Length;
                    if (path[dollyIndex] % 2 == 0)
                    {
                        mollyForwardFlowers += path[mollyIndex] / 2;
                        dollyBackwardFlowers += path[dollyIndex] / 2;
                        path[mollyIndex] = 0;
                    }
                    else
                    {
                        mollyForwardFlowers += (path[mollyIndex] - 1) / 2;
                        dollyBackwardFlowers += (path[dollyIndex] - 1) / 2;
                        path[mollyIndex] = 1;
                    }
                }

               
            }
            if (mollyIndex == dollyIndex)
            {
                Console.WriteLine("Draw");
            }
            else if(path[mollyIndex] == 0)
            {
                Console.WriteLine("Dolly");
            }
            else
            {
                Console.WriteLine("Molly");
            }
            Console.WriteLine(mollyForwardFlowers + " " + dollyBackwardFlowers);
        }
    }
}
