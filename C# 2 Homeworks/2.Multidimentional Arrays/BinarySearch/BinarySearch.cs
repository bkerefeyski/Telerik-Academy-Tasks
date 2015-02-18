//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter an array in format \" 6, 1, 2, 7, 12, 3");

        string input = Console.ReadLine();
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] num = input.Split(new Char[] { ',', ' ' },
                             StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


        Array.Sort(num);
        while (Array.BinarySearch(num, k) < 0)
        {
            k--;
        }

        Console.WriteLine("Largest number in the array which is less or equal to K is " + k);
    }
}