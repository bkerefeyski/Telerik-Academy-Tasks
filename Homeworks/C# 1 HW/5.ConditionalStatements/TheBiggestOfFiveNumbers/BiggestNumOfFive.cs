//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestNumOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        double number4 = double.Parse(Console.ReadLine());
        double number5 = double.Parse(Console.ReadLine());

        if (number1 >= number2 && number1 >= number3 && number1 >= number4 && number1 >= number5)
        {
            Console.WriteLine("biggest: " + number1);
        }
        else if (number2 >= number1 && number2 >= number3 && number2 >= number4 && number2 >= number5)
        {
            Console.WriteLine("biggest: " + number2);
        }
        else if (number3 >= number1 && number3 >= number2 && number3 >= number4 && number3 >= number5)
        {
            Console.WriteLine("biggest: " + number3);
        }
        else if (number4 >= number1 && number4 >= number2 && number4 >= number3 && number4 >= number5)
        {
            Console.WriteLine("biggest: " + number4);
        }
        else if (number5 >= number1 && number5 >= number2 && number5 >= number3 && number5 >= number4)
        {
            Console.WriteLine("biggest: " + number5);
        }
    }
}