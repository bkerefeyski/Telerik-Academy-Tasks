//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and 
//returns the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < n-1; j++)
        {
            for (int k = j+1; k < n; k++)
            {
                if(array[j] > array[k])
                {
                    int temp = array[j];
                    array[j] = array[k];
                    array[k] = temp;
                }
            }
        }
        int sum = 0;
        for (int l = 0; l < n; l++)
        {
            sum += array[l];
        }
        Console.WriteLine("min = {0}", array[0]);
        Console.WriteLine("max = {0}", array[n-1]);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:F2}", (double)sum/n);

    }
}