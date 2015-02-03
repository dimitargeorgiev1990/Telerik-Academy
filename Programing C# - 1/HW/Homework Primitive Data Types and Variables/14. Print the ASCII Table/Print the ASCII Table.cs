using System;

class PrinttheASCIITable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            char currentAsciSymbol = (char)i;
            Console.WriteLine("Code: " + i + " --> Symbol: " + currentAsciSymbol);
        }
    }
}
