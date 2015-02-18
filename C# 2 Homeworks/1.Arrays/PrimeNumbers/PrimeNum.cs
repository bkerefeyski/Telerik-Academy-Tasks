//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNum
    {
        static void Main(string[] args)
        {
            int start = 2;
            int end = 120;
            //List<int> prime = new List<int>();
            //prime.Add(1);
            //prime.Add(2);
            //prime.Add(3);
            //prime.Add(5);
            //prime.Add(7);

            
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(5);
            Console.WriteLine(7);
            for (int i = start; i <= end; i++)
            {
                if(!((i % 2 == 0) || (i % 3 == 0) || (i % 5 == 0) || (i % 7 == 0)))
                {
                    Console.WriteLine(i);
                    //prime.Add(i);
                }
             
            }

            //for (int i = 0; i < prime.Count; i++)
            //{
            //    Console.WriteLine(prime[i]);
            //}
        }
    }
}
