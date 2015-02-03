using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? value = null;
        double? value1 = null;

        Console.WriteLine("!    {0}    !", value); //! is to show the null value between them
        Console.WriteLine("!    {0}    !", value1);

        value = 2;
        value1 = 3.44;

        Console.WriteLine("\n" + value + "\n" + value1);
    }
}