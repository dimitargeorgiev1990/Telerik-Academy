using System;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class GravitationontheMoon
{
    static void Main()
    {
        Console.WriteLine("Insert weight: ");
        float weightOnEarth = float.Parse(Console.ReadLine());
        float weightOnMoon = weightOnEarth * 1.17f - weightOnEarth;
        Console.WriteLine("The weight on the Moon is: " + weightOnMoon);
    }
}
