//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many 
//numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersDividableByN
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integers:");
        Console.Write("Enter first integer:");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter first integer:");
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            int temp = first;
            first = second;
            second = temp;
        }


        int counter = 0;
        for (int i = first; i <= second; i++)
        {
            if(i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("{0} numbers that devide by 5 between first and second number.", counter);

        int[] arr = new int[counter];
        int ii = first;
        for(int j = 0; j < counter; j++)
        {
                
            while (ii <= second)
            {
                if (ii % 5 == 0)
                {
                    arr[j] = ii;
                    ii++;
                    break;
                }
                else
                {
                    ii++;
                }

            }
        }
        for(int j = 0; j < counter; j++)
        {
            Console.Write("{0}, ", arr[j]);
        }
    }
}