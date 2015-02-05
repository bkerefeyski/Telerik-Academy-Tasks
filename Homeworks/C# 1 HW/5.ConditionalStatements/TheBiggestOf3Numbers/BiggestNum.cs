//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.

using System;
class BiggestNum
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());

        if (number1 >= number2 && number1 >= number3)
        {
            Console.WriteLine("biggest: " + number1);
        }
        else if (number2 >= number1 && number2 >= number3)
        {
            Console.WriteLine("biggest: " + number2);
        }
        else if (number3 >= number1 && number3 >= number2)
        {
            Console.WriteLine("biggest: " + number3);
        }
    }
}