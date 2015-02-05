//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class SignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        Console.Write("Enter number 1: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 3: ");
        double number3 = double.Parse(Console.ReadLine());

        if (number1 == 0 || number2 == 0 || number3 == 0)
        {
            Console.WriteLine("result: " + 0);
        }
        else if (number1 > 0 && number2 > 0 && number3 > 0)
        {
            Console.WriteLine("result: " + "+");
        }
        else if (number1 < 0 ^ number2 < 0 ^ number3 < 0)
        {
            Console.WriteLine("result: " + "-");
        }
        else if (number1 < 0 && number2 < 0 && number3 < 0)
        {
            Console.WriteLine("result: " + "-");
        }
        else
        {
            Console.WriteLine("result: " + "+");
        }
    }
}