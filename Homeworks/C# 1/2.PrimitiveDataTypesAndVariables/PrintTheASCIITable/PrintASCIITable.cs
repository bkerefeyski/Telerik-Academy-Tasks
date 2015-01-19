//Problem 14.* Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a 
//program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine((char)i);
        }
        //Console.OutputEncoding = System.Text.Encoding.Unicode;
        //Console.Write("Decimal".PadRight(10));
        //Console.Write("ASCII".PadRight(10));
        //Console.Write("Hex".PadRight(10));
        //Console.WriteLine();

        //int min = 0;
        //int max = 127;
        //string lineSeparator;
        //for (int i = min; i < max; i++)
        //{
        //    // Get ascii character.
        //    char c = (char)i;

        //    // Get display string.
        //    string display = string.Empty;
        //    if (char.IsWhiteSpace(c))
        //    {
        //        display = c.ToString();
        //        switch (c)
        //        {
        //            case '\t':
        //                display = "\\t";
        //                break;
        //            case ' ':
        //                display = "space";
        //                break;
        //            case '\n':
        //                display = "\\n";
        //                break;
        //            case '\r':
        //                display = "\\r";
        //                break;
        //            case '\v':
        //                display = "\\v";
        //                break;
        //            case '\f':
        //                display = "\\f";
        //                break;
        //        }
        //    }
        //    else if (char.IsControl(c))
        //    {
        //        display = "control";
        //    }
        //    else
        //    {
        //        display = c.ToString();
        //    }
        //    // Write table row.
        //    Console.Write(i.ToString().PadRight(10));
        //    Console.Write(display.PadRight(10));
        //    Console.Write(i.ToString("X2"));
        //    Console.WriteLine();
        //}
        //lineSeparator = new string('=', 10);
        //Console.WriteLine(lineSeparator);
        //Console.WriteLine("press any key to end.");
        //Console.ReadKey();
    }
}