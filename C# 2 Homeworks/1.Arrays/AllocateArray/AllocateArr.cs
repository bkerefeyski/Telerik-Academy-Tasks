//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArr
{
    static void Main()
    {
        int[] arrayIntegers = new int[20];

        for (int i = 0; i < arrayIntegers.Length; i++)
        {
            arrayIntegers[i] = i * 5;
        }

        for (int i = 0; i < arrayIntegers.Length; i++)
        {
            Console.Write(arrayIntegers[i] + " ");
        }
        Console.WriteLine();
    }
}