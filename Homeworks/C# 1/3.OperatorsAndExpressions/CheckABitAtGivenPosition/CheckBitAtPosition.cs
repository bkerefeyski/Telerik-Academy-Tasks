//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given 
//integer number n, has value of 1.

using System;
class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter position p: ");
        int p = int.Parse(Console.ReadLine());
        int num1 = 1;

        int numBit = num >> p;
        int result = num1 & numBit;
        if (result == 1)
        {
            Console.WriteLine("The bit at position p is 1? True");
        }
        else
        {
            Console.WriteLine("The bit at position p is 1? False");
        }
    }
}