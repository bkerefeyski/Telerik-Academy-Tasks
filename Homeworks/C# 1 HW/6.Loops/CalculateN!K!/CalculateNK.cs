//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorielN = 1;
        int factorielK = 1;
        int counterN = 1;
        int counterK = 1;
        while (counterN <= n)
        {
            factorielN *= counterN;
            counterN++;
        }
        while (counterK <= k)
        {
            factorielK *= counterK;
            counterK++;
        }
        Console.WriteLine(factorielN / factorielK);
    }
}