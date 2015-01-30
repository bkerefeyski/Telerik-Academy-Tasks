using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSumFactoriels
{
    class SumFactoriels
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double sum = 1d;
            for (int i = 1; i <= n; i++)
            {
                int factorial = 1;
                int counter = 1;
                while(counter <= i)
                {
                    factorial *= counter;
                    counter++;
                }
                
                double factorialDivided = factorial / Math.Pow(x, i);

                sum += factorialDivided;
            }
            Console.WriteLine("{0:F5}", sum);

        }
    }
}
