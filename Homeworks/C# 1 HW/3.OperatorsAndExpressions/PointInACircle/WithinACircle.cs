//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class WithinACircle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates X and Y.");
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool inside = ((double)x * x) + ((double)y * y) <= 2;
        Console.WriteLine("The point is in the circle K({0, 0}, 2)? {0}", inside);
    }
}