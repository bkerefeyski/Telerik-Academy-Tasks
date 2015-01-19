//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, 
//sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class Variables
{
    static void Main()
    {
        sbyte number1 = 97;
        short number2 = -155;
        ushort number3 = 52130;
        int number4 = -10000;
        uint number5 = 4825932;

        
        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);
        Console.WriteLine(number4);
        Console.WriteLine(number5);

    }
}