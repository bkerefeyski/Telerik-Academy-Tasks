//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy5And7
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int i;
        string str = Console.ReadLine();
        bool parseSuccess = Int32.TryParse(str, out i);
        while (parseSuccess == false)
        {
            Console.WriteLine("Your number is invalid. Try again: ");
            str = Console.ReadLine();
            parseSuccess = Int32.TryParse(str, out i);
        }
        bool result = (i % 7 == 0) && (i % 5 == 0);
        Console.WriteLine("Your integer can be divided by 5 and 7? {0}", result);
    }
}