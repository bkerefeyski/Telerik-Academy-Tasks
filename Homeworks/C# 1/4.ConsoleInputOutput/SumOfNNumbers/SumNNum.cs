//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers 
//and calculates and prints their sum. Note: You may need to use a for-loop.

using System;
using System.Linq;


class SumNNum
{
    static void Main()
    {
        Console.WriteLine("This program sum the numbers you enter.");
        Console.Write("How many numbers you are about to enter?");
        int enter = int.Parse(Console.ReadLine());

        double[] arr = new double[enter];

        for(int i = 0; i < enter; i++)
        {
            Console.Write("Enter number {0} :", i+1);
            arr[i] = double.Parse(Console.ReadLine());
        }
        double sum = arr.Sum();

        Console.WriteLine("The sum of numbers is: {0}", sum);
    }
}