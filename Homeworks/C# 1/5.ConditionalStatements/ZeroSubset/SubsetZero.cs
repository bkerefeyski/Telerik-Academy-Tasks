//Problem 12.* Zero Subset
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

using System;
class SubsetZero
{
    static void Main()
    {
        Console.WriteLine("Enter five integers:");
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            int num;
            Console.Write("Enter integer {0}: ", i + 1);
            string str = Console.ReadLine();
            bool parseSuccess = Int32.TryParse(str, out num);
            while (parseSuccess == false)
            {
                Console.Write("Invalid number.Try again:");
                str = Console.ReadLine();
                parseSuccess = Int32.TryParse(str, out num);
            }
            arr[i] = num;
        }

        bool hasSubset = false;

        for (int j = 0; j < arr.Length - 1; j++)
        {
            for (int k = j + 1; k < arr.Length; k++)
            {
                if (arr[j] + arr[k] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", arr[j], arr[k]);
                    hasSubset = true;
                }
            }
        }
        for (int j = 1; j < arr.Length - 1; j++)
        {
            int counter = 0;
            int sum = arr[j - 1];
            int holter = arr[j];
            for (int k = j + 1; k < arr.Length; k++)
            {
                counter++;
               
                holter += arr[k];

                sum += holter;

                if (sum == 0 && counter == 1)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", arr[j-1], arr[k - 1], arr[k]);
                    hasSubset = true;
                }
                if (sum == 0 && counter == 2)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", arr[j - 1], arr[k - 2], arr[k-1], arr[k]);
                    hasSubset = true;
                }
                if (sum == 0 && counter == 3)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", arr[j-1], arr[k - 3], arr[k - 2], arr[k - 1], arr[k]);
                    hasSubset = true;
                }
            }
        }
        if (!hasSubset)
        {
            Console.WriteLine("No zero subset.");
        }
    }
}