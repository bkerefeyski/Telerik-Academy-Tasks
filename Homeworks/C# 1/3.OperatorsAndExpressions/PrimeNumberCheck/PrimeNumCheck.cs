//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without 
//remainder only to itself and 1).

using System;

class PrimeNumCheck
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int num = int.Parse(Console.ReadLine());

        bool prime = true;
        int minDevider = 2;
        int minDeviderNeg = -2;
        int maxDevider = (int)Math.Sqrt(num);

        if (num > 0 && num != 1)
        {
            while (prime && (minDevider <= maxDevider))
            {
                if (num % minDevider == 0)
                {
                    prime = false;
                }
                minDevider++;
            }
        }
        else if (num < 0 && (num != 1))
        {
            while (prime && (minDevider >= maxDevider))
            {
                if (num % minDevider == 0)
                {
                    prime = false;
                }
                minDevider--;
            }

        }
        else
        {
            prime = false;
        }
        Console.WriteLine("Prime? {0}", prime);
    }
}