//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//    ©
//
//   © ©
//
//  ©   ©
//
// © © © ©



using System;
using System.Text;

class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = (char)169;
        //char copy = '\u00A9';

        Console.WriteLine("   {0}\n", copyRight);
        Console.WriteLine("  {0} {1}\n", copyRight, copyRight);
        Console.WriteLine(" {0}   {1}\n", copyRight, copyRight);
        Console.WriteLine("{0} {1} {2} {3}", copyRight, copyRight, copyRight, copyRight);

        
    }
}