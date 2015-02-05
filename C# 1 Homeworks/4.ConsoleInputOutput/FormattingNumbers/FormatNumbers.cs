//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormatNumbers
{
    static void Main()
    {
        Console.Write("Write a number from 0 to 500:");
        int num;
        string str = Console.ReadLine();
        bool parseSuccess = Int32.TryParse(str, out num);
        while(parseSuccess == false)
        {
            Console.WriteLine("Invalid Number. Try again:");
            str = Console.ReadLine();
            parseSuccess = Int32.TryParse(str, out num);
        }
        Console.WriteLine("Write two floating-point numbers:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        Console.Write("Hex".PadRight(15));
        Console.Write("Bin".PadRight(8));
        Console.Write("2 digits|".PadRight(7));
        Console.Write("3 digits".PadRight(7));
        Console.WriteLine();

        string bin = Convert.ToString(num, 2).PadLeft(10, '0');
        Console.Write("{0,-10:X}|".PadRight(10), num);
        Console.Write("{0}|", bin);
        Console.Write("{0,10:F2}|", firstNum);
        Console.Write("{0,-10:F3}", secondNum);
    }
}