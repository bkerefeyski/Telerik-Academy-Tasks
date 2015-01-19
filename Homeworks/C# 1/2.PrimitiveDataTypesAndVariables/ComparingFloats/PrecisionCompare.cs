using System;

class PrecisionCompare
{
    static void Main()
    {
        Console.Write("Enter floating-point number 1:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter floating-point number 2:");
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001d;

        double result = firstNumber - secondNumber;
        if(result < eps)
        {
            Console.WriteLine("Precision of 0.000001 is true");
        }
        else
        {
            Console.WriteLine("Precision of 0.000001 is false");
        }
    }
}