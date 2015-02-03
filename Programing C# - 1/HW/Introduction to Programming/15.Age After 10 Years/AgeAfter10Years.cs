﻿using System;

class AgeAfter10Years
{
    static void Main()
    {

        Console.Write("Enter your birthday in format /dd.mm.yyyy/:");
        DateTime bitrhDay = DateTime.Parse(Console.ReadLine());

        int currentAge = DateTime.Today.Year - bitrhDay.Year;
        if (DateTime.Today.Month < bitrhDay.Month)
        {
            currentAge = currentAge - 1;
        }

        Console.WriteLine("Your age is {0}", currentAge);
        Console.WriteLine("Your age after 10 years will be {0}", currentAge + 10);
    }
}
