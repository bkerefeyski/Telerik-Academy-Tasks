//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length ; i++)
            {
                alphabet[i] = (char)(i + 65);
            }
            List<char> letters = new List<char>(alphabet);

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Count; j++)
                {
                    if(word[i] == letters[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            

            

        }
    }
}
