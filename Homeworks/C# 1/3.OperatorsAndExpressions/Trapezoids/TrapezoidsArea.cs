//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.WriteLine("Calculate the trapezoid`s area by given sides a and b and height h.");
        Console.Write("Enter side a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height h:");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        Console.WriteLine("The Area of the trapezoid is: {0}", area);
    }
}