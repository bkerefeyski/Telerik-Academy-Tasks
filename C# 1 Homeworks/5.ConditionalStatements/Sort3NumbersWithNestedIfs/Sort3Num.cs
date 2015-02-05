//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
class Sort3Num
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());

        if (number1 >= number2 && number1 >= number3)
        {
            if (number2 >= number3)
            {
                Console.WriteLine(number1 + "," + number2 + "," + number3);
            }
            else
            {
                Console.WriteLine(number1 + "," + number3 + "," + number2);
            }
        }

        else if (number2 >= number1 && number2 >= number3)
        {
            if (number1 >= number3)
            {
                Console.WriteLine(number2 + "," + number1 + "," + number3);
            }
            else
            {
                Console.WriteLine(number2 + "," + number3 + "," + number1);
            }
        }
        else if (number3 >= number1 && number3 >= number2)
        {
            if (number1 >= number2)
            {
                Console.WriteLine(number3 + "," + number1 + "," + number2);
            }
            else
            {
                Console.WriteLine(number3 + "," + number2 + "," + number1);
            }
        }
    }
}