using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;



namespace Problem_2___Decoding
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '@')
                {
                    break;
                }
                
                else if(text[i]>= 'A' && text[i] <= 'Z' ||text[i]>= 'a' && text[i] <= 'z')
                {
                    if(i % 2 == 0)
                    {
                       float ifLetterEven = ((text[i] * number) + 1000) /100f;
                        Console.WriteLine("{0:F2}", ifLetterEven);
                    }
                    else
                    { 

                    int ifLetterOdd = ((text[i] * number) + 1000) *100;
                    Console.WriteLine(ifLetterOdd);
                    }
                }
                else if(char.IsDigit(text[i]))
                {
                    if(i % 2 == 0)
                    {
                        float ifDigitEven = ((text[i] + number) + 500) / 100f;
                        Console.WriteLine("{0:F2}", ifDigitEven);
                    }
                    else
                    {
                        int ifDigitOdd = ((text[i] + number) + 500)*100;
                        Console.WriteLine(ifDigitOdd);
                    }
                   
                }
                else
                {
                    if(i % 2 == 0)
                    {
                        float ifElseSymbolEven = (text[i] - number)/100f;
                        Console.WriteLine("{0:F2}", ifElseSymbolEven);
                    }
                    else
                    {
                        int ifElseSymbolOdd = (text[i] - number) * 100;
                        Console.WriteLine(ifElseSymbolOdd);

                    }
                    
                }

            }

        }
    }
}
