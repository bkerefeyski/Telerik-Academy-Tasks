//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arrat in the format \"2, 3, -6, -1, 2, -1, 6, 4, -8, 8\"");
            string str = Console.ReadLine();

            int[] array = str.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int finalCounter = 0;
            int finalIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int currentCounter = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                       currentCounter++;
                      
                    }
                }
                if(finalCounter < currentCounter)
                {
                    finalCounter = currentCounter ;
                    finalIndex = i;
                }
                currentCounter = 0;

            }
            Console.Write(array[finalIndex]);
            Console.WriteLine("({0} times)", finalCounter+1);
        }
    }
}
