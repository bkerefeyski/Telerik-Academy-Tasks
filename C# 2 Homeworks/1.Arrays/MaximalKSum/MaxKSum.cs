//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class MaxKSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number N for array length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array:");

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter K for number of elements to sum. K <= N. K: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            int maxSum = 0;

            for (int i = 0; i < k; i++)
            {
                maxSum += array[i];
            }

            Console.WriteLine(maxSum);


        }
    }
}
