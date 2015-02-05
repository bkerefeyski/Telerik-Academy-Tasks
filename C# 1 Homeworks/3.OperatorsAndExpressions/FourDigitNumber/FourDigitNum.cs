//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FourDigitNum
{
    static void Main()
    {
        string number;
        Console.Write("Enter a four-digit number: ");

        number = Console.ReadLine();

        while ((number.Length != 4) || (number[0] == '0'))
        {
            Console.WriteLine("The number must have exactly 4 digits and should NOT start with \"0\".");
            Console.Write("Try again: ");
            number = Console.ReadLine();
        }
        int[] digits = number.Trim().ToCharArray().Select(x => Int32.Parse(x.ToString()))
            .ToArray();

        //Sum the numbers in string
        //int sum = number.ToString().Sum(c => c - '0');

        int sumNumbers = 0;
        foreach (var digit in digits)
        {
            sumNumbers += digit;
        }
        Console.WriteLine("Sum of digits: " + sumNumbers);

        //Reverse the integer.
        char[] reversed = number.ToCharArray();
        Array.Reverse(reversed);
        string reversedStr = new string(reversed);
        Console.WriteLine("Reversed digits: " + reversedStr);

        //Last digit in front
        char[] arrNumber = number.ToCharArray();
        char[] lastDigitInFront = new char[arrNumber.Length];
        for (int i = 1; i < arrNumber.Length; i++)
        {
            lastDigitInFront[i] = arrNumber[i - 1];
        }
        lastDigitInFront[0] = arrNumber[arrNumber.Length - 1];
        string lastDigitStr = new string(lastDigitInFront);
        Console.WriteLine("Last digit-first: " + lastDigitStr);

        //Second and third digits exchanged
        char temp = arrNumber[1];
        arrNumber[1] = arrNumber[2];
        arrNumber[2] = temp;
        string arrStr = new string(arrNumber);
        Console.WriteLine("Swap 2nd and 3rd: " + arrStr);
    }
}