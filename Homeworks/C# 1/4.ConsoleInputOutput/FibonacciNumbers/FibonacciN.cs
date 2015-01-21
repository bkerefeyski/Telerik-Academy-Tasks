//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the 
//first n members of the Fibonacci sequence (at a single line, separated 
//by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciN
{
    static void Main()
    {
        Console.WriteLine("This program prints the first N numbers from the Fibonacci sequence.");
        Console.Write("Enter N :");
        int n = int.Parse(Console.ReadLine());

        int[] arrNum = new int[n];

        for(int i = 0; i < n; i++)
        {
            if(i == 0)
            {
                arrNum[i] = 0;
            }
            else if(i == 1)
            {
                arrNum[i] = 1;
            }
            else
            {
                arrNum[i] = arrNum[i - 1] + arrNum[i - 2];
            }
            Console.Write("{0}, ", arrNum[i] );
        }
        Console.WriteLine();
    }
}