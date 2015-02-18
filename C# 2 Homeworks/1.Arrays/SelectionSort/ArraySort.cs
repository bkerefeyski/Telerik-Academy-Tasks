//Problem 7. Selection sort

//Sorting an array means to arrange its elements in 
//increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class ArraySort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program sort an array.");

            Console.Write("Enter N for arrat length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            //int[] array = new int[] { 5, 1, 2, 6, 8, 3, 4 };
            Console.WriteLine("Enter elements of array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Sorting the array
            int minValue;
            for (int i = 0; i < array.Length -1; i++)
            {
                int minIndex = -1;
                minValue = int.MaxValue;
                for (int j = i+1; j < array.Length; j++)
                {
                    if(minValue > array[j])
                    {
                        minValue = array[j];
                        minIndex = j;
                    }

                }

                int temp = array[i];
                array[i] = minValue;
                array[minIndex] = temp;

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
