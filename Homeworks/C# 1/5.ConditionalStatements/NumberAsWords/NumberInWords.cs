//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
using System.Linq;





class NumberInWords
{
    static void Main()
    {
        Console.WriteLine("Enter number in the range 0...999:");
        int number = int.Parse(Console.ReadLine());
        int[] digits = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
        //int num2 = digits[2];
        //int num1 = digits[1];
        //int num0 = digits[0];
        int num2 = 0;
        int num1 = 0;
        int num0 = 0;
        if (digits.Length == 1)
        {
            num2 = digits[0];
        }
        if(digits.Length == 2)
        {
            num2 = digits[1];
            num1 = digits[0];
        }
        if(digits.Length == 3)
        {
            num2 = digits[2];
            num1 = digits[1];
            num0 = digits[0];
        }

        string numStr2 = "";
        switch (num2)
        {
            case 0: numStr2 = "zero"; break;
            case 1: numStr2 = "one"; break;
            case 2: numStr2 = "two"; break;
            case 3: numStr2 = "three"; break;
            case 4: numStr2 = "four"; break;
            case 5: numStr2 = "five"; break;
            case 6: numStr2 = "six"; break;
            case 7: numStr2 = "seven"; break;
            case 8: numStr2 = "eight"; break;
            case 9: numStr2 = "nine"; break;
        }
        string numStr1 = "";
        switch (num1)
        {
            case 1: numStr1 = "ten"; break;
            case 2: numStr1 = "twenty"; break;
            case 3: numStr1 = "thirty"; break;
            case 4: numStr1 = "forty"; break;
            case 5: numStr1 = "fifty"; break;
            case 6: numStr1 = "sixty"; break;
            case 7: numStr1 = "seventy"; break;
            case 8: numStr1 = "eighty"; break;
            case 9: numStr1 = "ninety"; break;
        }
        string numStr0 = "";
        switch (num0)
        {
            case 1: numStr0 = "one"; break;
            case 2: numStr0 = "two"; break;
            case 3: numStr0 = "three"; break;
            case 4: numStr0 = "four"; break;
            case 5: numStr0 = "five"; break;
            case 6: numStr0 = "six"; break;
            case 7: numStr0 = "seven"; break;
            case 8: numStr0 = "eight"; break;
            case 9: numStr0 = "nine"; break;
        }



        if (digits.Length == 1)
        {
            Console.WriteLine("The Number in words: {0}", numStr2);
        }
        if(digits.Length == 2)
        {
            if(digits[1] == 0)
            {
                Console.WriteLine("The Number in words: {0}", numStr1);
            }
            else
            {
                Console.WriteLine("The Number in words: {0} {1}", numStr1,numStr2);
            }
        }
        if(digits.Length == 3)
        {
            if (digits[2] == 0 && digits[1] == 0)
            {
                Console.WriteLine("The Number in words: {0} thousand", numStr0);
            }
            else if(digits[1] == 0)
            {
                Console.WriteLine("The Number in words: {0} thousand and {1}", numStr0, numStr2);
            }
            else if (digits[2] == 0)
            {
                Console.WriteLine("The Number in words: {0} thousand and {1}", numStr0, numStr1);
            }
            else
            {
                Console.WriteLine("The Number in words: {0} thousand and {1} {2}", numStr0, numStr1, numStr2);
            }
        }
    

        //    if (digits.Length == 1)
        //    {
        //        From1To9(digits[0]);
        //    }
        //    if (digits.Length == 2)
        //    {
        //        From10To99(digits[0], digits[1]);
        //    }
    }
        //static void From1To9(int num)
        //{

        //    string numStr = "";
        //    switch (num)
        //    {
        //        case 1: numStr = "one"; break;
        //        case 2: numStr = "two"; break;
        //        case 3: numStr = "three"; break;
        //        case 4: numStr = "four"; break;
        //        case 5: numStr = "five"; break;
        //        case 6: numStr = "six"; break;
        //        case 7: numStr = "seven"; break;
        //        case 8: numStr = "eight"; break;
        //        case 9: numStr = "nine"; break;
        //    }
        //    Console.WriteLine("Number in words: {0}", numStr);
        //}
        //static void From10To99(int num, int num1)
        //{
        //    if(num1 == 0)
        //    {

        //        switch(num)
        //        {
        //            case 10: numStr1 = "ten"; break;
        //            case 20: numStr1 = "twenty"; break;
        //            case 30: numStr1 = "thirty"; break;
        //            case 40: numStr1 = "forty"; break;
        //            case 50: numStr1 = "fifty"; break;
        //            case 60: numStr1 = "sixty"; break;
        //            case 70: numStr1 = "seventy"; break;
        //            case 80: numStr1 = "eighty"; break;
        //            case 90: numStr1 = "ninety"; break;
        //        }
        //    }

        //    string numStr = "";
        //    switch (num)
        //    {
        //        case 1: numStr = "one"; break;
        //        case 2: numStr = "two"; break;
        //        case 3: numStr = "three"; break;
        //        case 4: numStr = "four"; break;
        //        case 5: numStr = "five"; break;
        //        case 6: numStr = "six"; break;
        //        case 7: numStr = "seven"; break;
        //        case 8: numStr = "eight"; break;
        //        case 9: numStr = "nine"; break;
        //    }
        //    Console.WriteLine("Number in words: {0}", numStr);
        //}
    
}