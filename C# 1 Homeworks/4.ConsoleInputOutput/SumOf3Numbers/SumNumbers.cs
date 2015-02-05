//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumNumbers
{
    static void Main()
    {
        Console.WriteLine("This program sum 3 real number.");
        Console.Write("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());

        double result = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the numbers is: {0}", result);

    }
}