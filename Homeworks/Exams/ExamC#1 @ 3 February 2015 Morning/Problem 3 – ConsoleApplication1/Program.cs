using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_3___ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit;
            BigInteger counter = 0;
            BigInteger currentDigit;
            BigInteger finalProduct = 1;
            BigInteger finalProductOver10 = 1;

            while(true)
            {
                BigInteger currentProduct = 1;
                BigInteger currentProductOver10 = 1;
                digit = Console.ReadLine();
                if( digit == "END" )
                {
                    break;
                }

                //currentDigit = BigInteger.Parse(digit);
                counter++;

                if (counter <= 10 && counter % 2 == 0)
                {
                    for (int i = 0; i < digit.Length; i++)
                    {
                        if(digit[i] == '0')
                        {
                            continue;
                        }
                        else
                        { 
                            currentProduct *= BigInteger.Parse(digit[i].ToString());
                        }
                    }
                }
                finalProduct *= currentProduct;

                if (counter > 10 && counter % 2 == 0)
                {
                    for (int i = 0; i < digit.Length; i++)
                    {
                        if (digit[i] == '0')
                        {
                            continue;
                        }
                        else
                        {
                            currentProductOver10 *= BigInteger.Parse(digit[i].ToString());
                        }
                    }
                }
                finalProductOver10 *= currentProductOver10;
            }

            if(counter > 10)
            {
                Console.WriteLine(finalProduct);
                Console.WriteLine(finalProductOver10);
            }
            else
            { 
            Console.WriteLine(finalProduct);
            }
           

        }
    }
}
