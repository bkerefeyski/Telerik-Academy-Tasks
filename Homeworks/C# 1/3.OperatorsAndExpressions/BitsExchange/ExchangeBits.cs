//Problem 15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        //Convert number (long, int) to string with binary representation
        Console.Write("Please enter positive integer: ");
        uint num;
        string str = Console.ReadLine();
        bool parseSuccess = uint.TryParse(str, out num);
        while (parseSuccess == false)
        {
            Console.WriteLine("Invalid number. Try again: ");
            str = Console.ReadLine();
            parseSuccess = uint.TryParse(str, out num);
        }

        string numBin = Convert.ToString(num, 2).PadLeft(32, '0');
        Console.WriteLine("Binary input: {0}", numBin);

        char[] array = numBin.ToCharArray();
        //we reverse the array because in bin we count from right to left    3<-2<-1<-0
        //but in char[] we count from left to right 0->1->2->3
        Array.Reverse(array);

        char temp;

        temp = array[3];
        array[3] = array[24];
        array[24] = temp;

        temp = array[4];
        array[4] = array[25];
        array[25] = temp;

        temp = array[5];
        array[5] = array[26];
        array[26] = temp;

        Array.Reverse(array);
        //from char array put in string and print from binary to integer
        string newNum = new string(array);
        uint outPut = Convert.ToUInt32(newNum, 2);
        Console.WriteLine("Binary result: {0}", newNum);
        Console.WriteLine("Decimal result: {0}", outPut);
    }
}