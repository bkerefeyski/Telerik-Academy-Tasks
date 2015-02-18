//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinSearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arrat in the format \"4, 3, 1, 4, 2, 5, 8\"");
            string str = Console.ReadLine();
            Console.WriteLine("Enter element to search: ");
            int element = int.Parse(Console.ReadLine());
            int[] arrayNums = str.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            Array.Sort(arrayNums);
            
            Console.WriteLine(string.Join(",", arrayNums));

            //List<int> arrayList = new List<int>(arrayNums);
            //int result = arrayList.BinarySearch(element);
            //Console.WriteLine(result);

            int result = BinarySearch(arrayNums, element, 0, arrayNums.Length);
            if(result == -1)
            {
                Console.WriteLine("Number {0} not found!", element);
            }
            else
            {
                Console.WriteLine("Number {0} found at index: {1}", element, result);
            }
        }
        static int BinarySearch(int[] nums, int searchElement, int start, int end)
        {
            if(end < start)
            {
                return -1;
            }

            int middleElement = (start + end) / 2;

            if(nums[middleElement] > searchElement)
            {
                return BinarySearch(nums, searchElement, start, middleElement - 1);
            }
            else if(nums[middleElement] < searchElement)
            {
                return BinarySearch(nums, searchElement, middleElement + 1, end);
            }
            else 
            {
                return middleElement;
            }
            
        }
    }
}
