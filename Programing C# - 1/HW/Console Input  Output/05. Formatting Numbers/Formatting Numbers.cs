﻿using System;

/* Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned.*/

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Write an integer between 0 and 500: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Write a float-point number: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Write another float-point number: ");
        float c = float.Parse(Console.ReadLine());

        Console.Write("{0,-10}|", a.ToString("X"));
        Console.Write("{0}|", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("{0,10:F2}|", b);
        Console.WriteLine("{0,-10:F3}|", c);
    }
}
