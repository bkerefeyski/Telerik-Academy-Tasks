//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main()
    {
        int? firstValue = null;
        double? secondValue = null;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);

        firstValue += 5;
        secondValue += 5.5d;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);

        firstValue += null;
        secondValue += null;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
    }
}