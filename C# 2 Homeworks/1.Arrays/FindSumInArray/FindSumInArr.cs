//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInArray
{
    class FindSumInArr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arrat in the format \"4, 3, 1, 4, 2, 5, 8\"");
            string str = Console.ReadLine();
            Console.Write("Enter number S:");
            int s = int.Parse(Console.ReadLine());
            int[] array = str.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            bool hasSum = false;
            int sum = 0;
            int counter = 0;
            //int startPossition = 0;
            for (int i = 0; i < array.Length -1; i++)
            {
                sum += array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    sum += array[j];
                    counter++;

                    if(sum == s)
                    {
                        hasSum = true;
                        //startPossition = i;
                        for (int k = i; k <= i + counter; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        Console.WriteLine();
                        break;
                    }
                    if(sum > s)
                    {
                        sum = 0;
                        counter = 0;
                        break;
                    }
                }
                sum = 0;
            }
            if(!hasSum)
            {
                Console.WriteLine("There is no sum.");
            }
        }
    }
}
