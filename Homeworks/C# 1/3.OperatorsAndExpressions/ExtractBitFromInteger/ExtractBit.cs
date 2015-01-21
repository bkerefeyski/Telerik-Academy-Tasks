//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter index p for position: ");
        int index = int.Parse(Console.ReadLine());
        int num1 = 1;
        int numBit = (num >> index);
        int result = num1 & numBit;
        Console.WriteLine("The bit at index p is: {0}", result);
    }
}