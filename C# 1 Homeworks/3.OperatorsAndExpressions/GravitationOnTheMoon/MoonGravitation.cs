//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class MoonGravitation
{
    static void Main()
    {
        Console.WriteLine("Enter weight. For separator use \",\"");
        double weight = double.Parse(Console.ReadLine());
        double moonGravity = (double)17 / 100;
        double weightOnTheMoon = weight * moonGravity;
        Console.WriteLine(weightOnTheMoon);
    }
}