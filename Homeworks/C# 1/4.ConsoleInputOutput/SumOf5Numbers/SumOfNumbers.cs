//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers (given in a single line, separated by a space):");
        string num = Console.ReadLine();
        char[] ch = new char[] { ' ' };
        string[] array = num.Split(ch, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += double.Parse(array[i]);
        }

        Console.WriteLine(sum);
    }
}