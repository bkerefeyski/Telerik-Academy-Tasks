//Problem 1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater 
//than the second one. As a result print the values a and b, separated by a space.

using System;
using System.Globalization;
using System.Threading;
class ExchangeGreater
{
    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter two numbers.");
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        if(firstNum > secondNum)
        {
            Console.WriteLine("{0} {1}", secondNum, firstNum);
        }
        else
        {
            Console.WriteLine("{0} {1}", secondNum, firstNum);
        }
    }
}