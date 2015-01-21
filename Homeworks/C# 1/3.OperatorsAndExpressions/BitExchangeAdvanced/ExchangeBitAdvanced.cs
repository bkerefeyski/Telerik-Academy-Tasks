//Problem 16.** Bit Exchange (Advanced)
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned 
//integer.
//The first and the second sequence of bits may not overlap.

using System;

class ExchangeBitAdvanced
{
    static void Main()
    {
        Console.Write("Please enter positive integer: ");
        Console.Write("Enter number:");
        uint num;
        string readStr = Console.ReadLine();
        bool parseSuccess = UInt32.TryParse(readStr, out num);
        while (parseSuccess == false)
        {
            Console.Write("Your input is invalid: ");
            readStr = Console.ReadLine();
            parseSuccess = UInt32.TryParse(readStr, out num);
        }
        /////////////////
        Console.Write("Enter p:");
        int p;
        readStr = Console.ReadLine();
        parseSuccess = Int32.TryParse(readStr, out p);
        while (p < 0 || parseSuccess == false)
        {
            Console.Write("Position is invalid. It should be >= 0. Try again: ");
            readStr = Console.ReadLine();
            parseSuccess = Int32.TryParse(readStr, out p);
        }
        /////////////////
        Console.Write("Enter q:");
        int q;
        readStr = Console.ReadLine();
        parseSuccess = Int32.TryParse(readStr, out q);
        while (q < 0 || parseSuccess == false)
        {
            Console.Write("Position is invalid. It should be >= 0. Try again: ");
            readStr = Console.ReadLine();
            parseSuccess = Int32.TryParse(readStr, out q);
        }
        ///////////////
        Console.Write("Enter k:");
        int k;
        readStr = Console.ReadLine();
        parseSuccess = Int32.TryParse(readStr, out k);
        while (k <= 0 || parseSuccess == false)
        {
            Console.Write("Number is invalid. It should be > 0. Try again: ");
            readStr = Console.ReadLine();
            parseSuccess = Int32.TryParse(readStr, out k);
        }

        string numBit = Convert.ToString(num, 2).PadLeft(32, '0');

        char[] array = numBit.ToCharArray();
        Array.Reverse(array);

        int bitsP = p + (k - 1);
        //int bitsQ = q + (k - 1);
        for (int i = p, j = q; p <= bitsP; p++, q++)
        {
            char temp;
            temp = array[p];
            array[p] = array[q];
            array[q] = temp;
        }

        Array.Reverse(array);
        string newNum = new string(array);
        uint outPut = Convert.ToUInt32(newNum, 2);
        Console.WriteLine("Binary result: {0}", newNum);
        Console.WriteLine("Integer result: {0}", outPut);
    }
}