//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
class OddEvenProduct
{
    static void Main()
    {
        string num = Console.ReadLine();
        char[] charsToTrim = { ' ' };
        string[] numArr = num.Split(charsToTrim, StringSplitOptions.RemoveEmptyEntries);
        int productOdd = 1;
        int productEven = 1;



        for (int i = 0; i < numArr.Length; i++)
        {
            if (i % 2 == 0)
            {

                productOdd *= int.Parse(numArr[i]);
            }
            else
            {
                productEven *= int.Parse(numArr[i]);
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", productOdd);
            Console.WriteLine("even_product = {0}", productEven);
        }
    }
}