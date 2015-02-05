using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Persian_rugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 2 * n + 1;
            
            //UpperPart
            int sideDots = 0;
            int middleSpaceAll = width -2 ;
            int middleTriangleDots = (width - 2) - (d * 2) - 2;
            int emptyMiddleSpace = middleSpaceAll - (middleTriangleDots +2);
            int counter = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('#', sideDots));
                Console.Write("\\");
                //Upper Triangle
                if (d * 2 <= emptyMiddleSpace && middleTriangleDots >= 1)
                {
                    Console.Write(new string(' ', emptyMiddleSpace / 2));
                    Console.Write("\\");
                    Console.Write(new string('.', middleTriangleDots));
                    Console.Write("/");
                    Console.Write(new string(' ', emptyMiddleSpace / 2));
                    middleTriangleDots -= 2;
                    counter++;

                }
                else
                {
                    Console.Write(new string(' ', middleSpaceAll));
                }
                
                Console.Write("/");
                Console.Write(new string('#', sideDots));
                sideDots++;
                middleSpaceAll -= 2;
                

                Console.WriteLine();
            }
            

            //Midde Line fixed
            Console.WriteLine(new string('#', n) + "X" + new string('#', n));
            
            //Bottom part

            int middleTriangleDownDots = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('#', sideDots - 1));
                Console.Write("/");

                if (d * 2 <= emptyMiddleSpace && i >= n - counter+1 && i <= n)
                {
                    Console.Write(new string(' ', emptyMiddleSpace / 2));
                    Console.Write("/");
                    Console.Write(new string('.', middleTriangleDownDots));
                    Console.Write("\\");
                    Console.Write(new string(' ', emptyMiddleSpace / 2));
                    middleTriangleDownDots += 2;
                }
                else
                {
                    Console.Write(new string(' ', middleSpaceAll + 2));
                }

                Console.Write("\\");
                Console.Write(new string('#', sideDots - 1));
                sideDots--;
                middleSpaceAll += 2;

                Console.WriteLine();
            }


        }
    }
}
