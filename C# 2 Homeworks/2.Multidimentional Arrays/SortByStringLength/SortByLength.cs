//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortByLength
{
    static void Main()
    {
        Console.WriteLine("Enter a string array in format \"hello, Wellcome, come\"");
        string input = Console.ReadLine();
        string[] array = input.Split(new Char[] { ',', ' ' },
                             StringSplitOptions.RemoveEmptyEntries).ToArray();

        //for (int i = 0; i < array.Length-1; i++)
        //{
        //    for (int j = i+1; j < array.Length; j++)
        //    {
        //        if(array[i].Length > array[j].Length)
        //        {
        //            string temp = array[i];
        //            array[i] = array[j];
        //            array[j] = temp;

        //        }
        //    }
        //}

        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine(string.Join(" ", array));

    }
} string[] inputArr = new string[]{"hello", "welcome", "busy"};