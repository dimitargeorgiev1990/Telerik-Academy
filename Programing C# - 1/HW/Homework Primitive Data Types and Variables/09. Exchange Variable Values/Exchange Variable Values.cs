using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before the convertion: ");
        Console.WriteLine(a);
        Console.WriteLine(b);

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("\nAfter the convertion: ");
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}
