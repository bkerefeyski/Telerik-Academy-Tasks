//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from 
//the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitAtPos
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter position p: ");
        int p = int.Parse(Console.ReadLine());
        int num1 = 1;
        int bit1 = num >> p;
        int isOne = num1 & bit1;
        if (isOne == 1)
        {
            int bitOne = ~(num1 << p);
            int result = num & bitOne;

            Console.WriteLine("Binary result: {0}", Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("Decimal result: {0}", result);
        }
        else
        {
            int bitZero = num1 << p;
            int result = num | bitZero;

            //Print in Binary with 16 digits fill with zero
            //string resultBin = Convert.ToString(result, 2);
            Console.WriteLine("Binary result: {0}", Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("Decimal result: {0}", result);
        }
    }
}