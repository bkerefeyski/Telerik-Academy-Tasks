//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array in the format\"2, 1, 1, 2, 3, 3, 2, 2, 2, 1\":");
            string inputStr = Console.ReadLine();
            string[] array = inputStr.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] array = new string[] { "2", "1", "1", "2", "3", "3", "2", "2", "2", "1"};
            int count = 0;
            int startIndex = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int currentCount = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    
                    if (array[i] != array[j])
                    {
                        break;
                    }
                    else
                    {
                        currentCount++;
                    }
                }
                if (currentCount > count)
                {
                    count = currentCount;
                    startIndex = i;
                }
                currentCount = 0;
            }
            
            for (int i = startIndex; i <= startIndex + count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
