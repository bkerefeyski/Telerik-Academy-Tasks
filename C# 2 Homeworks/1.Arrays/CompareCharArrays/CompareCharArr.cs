//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArr
{
    static void Main()
    {
        
        Console.WriteLine("This program compares two char arrays letter by letter.");
        Console.Write("Enter first array: ");
        string firstStr = Console.ReadLine();
        Console.Write("Enter second array: ");
        string secondStr = Console.ReadLine();

        char[] firstArr = firstStr.ToCharArray();
        char[] secondArr = secondStr.ToCharArray();

        bool arraysMatch = true;
       
        if(firstArr.Length != secondArr.Length)
        {
            arraysMatch = false;
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if(firstArr[i] != secondArr[i])
                {
                    arraysMatch = false;
                    break;
                }
            }
        }
        if(arraysMatch)
        {
            Console.WriteLine("Arrays are the same.");
        }
        else
        {
            Console.WriteLine("Arrays are differet.");
        }
    }
}