using System;

class StringsandObjects
{
    static void Main()
    {
        string a = "Hello ";
        string b = "World";

        object obj = (a + b);
        Console.WriteLine(obj);

        string c = (string)obj;
        Console.WriteLine(c);
    }
}
