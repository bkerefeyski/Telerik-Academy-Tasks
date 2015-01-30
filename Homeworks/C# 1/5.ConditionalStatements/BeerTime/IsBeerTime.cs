//Problem 10.* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” 
//(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time 
//or non-beer time according to the definition above or invalid time 
//if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;
class IsBeerTime
{
    static void Main()
    {
        Console.WriteLine("Please enter time in format \"hh:mm AM/PM\"");
        string input = Console.ReadLine();

        try
        {
            DateTime timeNow = DateTime.ParseExact(input, "hh:mm tt", CultureInfo.InvariantCulture);
            //bool parseSuccess = DateTime.TryParse(input, out timeNow);

            //Console.WriteLine(timeNow.ToString("hh:mm tt", CultureInfo.InvariantCulture));
            DateTime now = Convert.ToDateTime(timeNow);
            DateTime beerTimeStart = Convert.ToDateTime("01:00 PM", CultureInfo.InvariantCulture);
            DateTime beerTimeEnd = Convert.ToDateTime("03:00 AM", CultureInfo.InvariantCulture);

            //int start = DateTime.Compare(now, beerTimeStart);
            //Console.WriteLine(start);
            //int end = DateTime.Compare(now, beerTimeEnd);
            //Console.WriteLine(end);

            if (now > beerTimeStart && now > beerTimeEnd)
            {
                Console.WriteLine("Beer time.");
            }
            else
            {
                Console.WriteLine("Non-Beer time.");
            }
        }
        catch(Exception)
        {
            Console.WriteLine("invalid time");
        }
    }
}