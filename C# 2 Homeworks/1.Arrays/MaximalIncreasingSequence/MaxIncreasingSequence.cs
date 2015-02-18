//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array in the format\"2, 1, 1, 2, 3, 3, 2, 2, 2, 1\":");
            string inputStr = Console.ReadLine();
            int[] array = inputStr.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int count = 0;
            int startIndex = 0;
            int increaseWith = 1;

            for (int i = 0; i < array.Length -1; i++)
            {
                int currentCount = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j] - array[i] != increaseWith)
                    {
                        break;
                    }
                    else
                    {
                        currentCount++;
                        increaseWith++;
                    }
                }
                if (currentCount > count)
                {
                    count = currentCount;
                    startIndex = i;
                }
                currentCount = 0;
                increaseWith = 1;
            }
            for (int i = startIndex; i <= startIndex + count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
