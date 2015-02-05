using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Search_in_Bits
{
    class Program
    {
        static void Main(string[] args)
        {

            int S = int.Parse(Console.ReadLine());
            int nForLoop = int.Parse(Console.ReadLine());
            int fifteen = 15;

            //string bin15 = Convert.ToString(fifteen, 2).PadLeft(30, '0');
            //string binS = Convert.ToString(fifteen, 2).PadLeft(30, '0');

            int result = S & fifteen;
            //string binResult = Convert.ToString(result, 2).PadLeft(30, '0');
            int counter = 0;

            for (int i = 0; i < nForLoop; i++)
            {

                int num = int.Parse(Console.ReadLine());
                
                int currentResult = 0; 

                for(int j = 1; j <= 27; j++)
                {
                    currentResult = fifteen & num;
                    num = num >> 1;

                    if (currentResult == result)
                    {
                        counter++;
                    }
                }  
			}

            Console.WriteLine(counter);
            

        }
    }
}
