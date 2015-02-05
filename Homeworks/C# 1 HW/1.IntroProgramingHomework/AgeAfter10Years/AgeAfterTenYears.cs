//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Please enter your birthday (format DD.MM.YYYY):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int dayOfBirth = birthday.Day;
        int monthOfBirth = birthday.Month;
        int yearOfBirth = birthday.Year;
        int currentАge = (DateTime.Now.Year - yearOfBirth);
        int ageInTenYears = ((DateTime.Now.Year - yearOfBirth) + 10);
        if(DateTime.Now.Day >= dayOfBirth && DateTime.Now.Month >= monthOfBirth)
        {
            Console.WriteLine("You are {0} years old.", currentАge);
            Console.WriteLine("After ten years you will be {0} years old.", ageInTenYears);
        }
        else
        {
            Console.WriteLine("You are {0} years old.", currentАge - 1);
            Console.WriteLine("After ten years you will be {0} years old.", ageInTenYears - 1);
        }
    }
}