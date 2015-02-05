//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area 
//formatted with 2 digits after the decimal point.

using System;
class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Enter radius of circle:");
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("The perimeter of the circle is: {0:F2}", perimeter);
        Console.WriteLine("The area of the circle is: {0:F2}", area);
    }
}