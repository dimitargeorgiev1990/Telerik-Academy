using System;

namespace Nightmare_on_Code_Street
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) && i % 2 != 0)
                {
                    sum += int.Parse(text[i].ToString());
                    count++;
                }
            }
            Console.WriteLine(count + " " + sum);
        }
    }
}
