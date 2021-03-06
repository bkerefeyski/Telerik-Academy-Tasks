﻿//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;
using System.Numerics;

class CalculateNKNK
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger counterN = 1;
        BigInteger counterK = 1;
        BigInteger factorielNMinusK = 1;
        BigInteger counterNMinusK = 1;
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
        while (counterNMinusK <= n - k)
        {
            factorielNMinusK *= counterNMinusK;
            counterNMinusK++;
        }
        Console.WriteLine(factorielN / (factorielK * factorielNMinusK));
    }
}