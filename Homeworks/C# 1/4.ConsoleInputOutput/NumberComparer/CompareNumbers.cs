﻿//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double result = Math.Max(firstNum, secondNum);
            
        Console.WriteLine("Greater number is: {0}", result);
    }
}