//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter an arrat in the format \"2, 3, -6, -1, 2, -1, 6, 4, -8, 8\"");
        string str = Console.ReadLine();

        int[] array = str.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        
        int finalSum = 0;
        int finalStartIndex = 0;
        int finalCounter = 0;
        int currentSum = 0;
        
        int currentCounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
                
            currentSum += array[i];
            currentCounter++;

            if(currentSum <= 0)
            {

                currentSum = 0;
                currentCounter = 0;

            }
            if(finalSum < currentSum)
            {
                finalSum = currentSum;
                finalStartIndex = i;
                finalCounter = currentCounter;
            }
        }
        //Print result
        for (int i = finalStartIndex - finalCounter+1; i <= finalStartIndex ; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}