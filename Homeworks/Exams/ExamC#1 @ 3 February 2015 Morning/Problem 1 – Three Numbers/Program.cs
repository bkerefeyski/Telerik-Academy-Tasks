using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;
using System.Globalization;


namespace Problem_1___Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long biggestNum = 0;
            long smallestNum = 0;
            decimal aritmetic = ((decimal)a + b + c) / 3;

            if(a >= b && a >= c)
            {
                biggestNum = a;
            }
            else if(b >= a && b >= c)
            {
                biggestNum = b;
            }
            else if (c >= a && c >= b)
            {
                biggestNum = c;
            }

            if(a <= b && a <= c)
            {
                smallestNum = a;
            }
            else if (b <= a && b <= c)
            {
                smallestNum = b;
            }
            else if( c <= a && c <= b)
            {
                smallestNum = c;
            }

            Console.WriteLine(biggestNum);
            Console.WriteLine(smallestNum);
            Console.WriteLine("{0:F2}", aritmetic);
        }
    }
}
