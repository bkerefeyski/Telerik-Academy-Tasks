//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after 
//that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Value of 'a' is: {0}", a);
        Console.WriteLine("Value of 'b' is: {0}", b);

        Console.WriteLine("After exchange:");
        int temp;
        temp = a;
        a = b;
        b = temp;
        //int exchangeA = (a + b) - a;
        //int exchangeB = (a + b) - b;
        Console.WriteLine("Value of 'a' is: {0}", a);
        Console.WriteLine("Value of 'b' is: {0}", b);
        
    }
}