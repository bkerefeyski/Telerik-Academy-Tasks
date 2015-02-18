//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArr
{
    static void Main()
    {
        Console.WriteLine("This procram compares two arrays.");
        Console.WriteLine("Please enter two arrays from the console.");
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        

        Console.WriteLine("Enter first array:");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter array length: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second array:");
        int[] secondArray = new int[m];
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        if(firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Arrays are different.");
        }
        else
        { 
            bool arraysMatch = true;
            for (int i = 0; i < n; i++)
            {
                if(firstArray[i] != secondArray[i])
                {
                    arraysMatch = false;
                    break;
                }
            }
            if(arraysMatch)
            {
                Console.WriteLine("Arrays are the same.");
            }
            else
            {
                Console.WriteLine("Arrays are different.");
            }
        }
    }
}