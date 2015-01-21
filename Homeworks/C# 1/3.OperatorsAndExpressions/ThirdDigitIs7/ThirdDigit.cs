//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        int number;
        string numberStr = Console.ReadLine();
        bool parseSuccess = Int32.TryParse(numberStr, out number);
        while(parseSuccess == false)
        {
            Console.WriteLine("Your integer is not valid. Try again: ");
            numberStr = Console.ReadLine();
            parseSuccess = Int32.TryParse(numberStr, out number);
        }
        string digit = number.ToString();
        char ch = '7';
        int thirdDigitRightLeft = digit.Length - 3;
        char digit3 = digit[thirdDigitRightLeft];
        bool result = (digit.Length >= 3) && (digit3 == ch);
        Console.WriteLine("Your integer's third digit (right-to-left) is 7 ? {0}", result);
    }
}