//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class RectanglePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("This program calculates perimeter and area of rectangle.");
        Console.Write("Enter Width:");
        decimal width;
        string widthStr = Console.ReadLine();
        bool parseSuccess = decimal.TryParse(widthStr, out width);
        while(width <= 0 || parseSuccess == false)
        {
            Console.WriteLine("Width is invalid. It should be > 0. Try again: ");
            widthStr = Console.ReadLine();
            parseSuccess = decimal.TryParse(widthStr, out width);
        }

        Console.Write("Enter Height:");
        decimal height;
        string heightStr = Console.ReadLine();
        parseSuccess = decimal.TryParse(widthStr, out height);
        while (width <= 0 || parseSuccess == false)
        {
            Console.WriteLine("Height is invalid. It should be > 0. Try again: ");
            widthStr = Console.ReadLine();
            parseSuccess = decimal.TryParse(widthStr, out height);
        }

        decimal perimeter = 2 * ((decimal)width + height);
        decimal area = (decimal)width * height;
        Console.WriteLine("The perimeter of the rectangle is: {0} ", perimeter);
        Console.WriteLine("The area of the rectangle is: {0} ", area);
    }
}