//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class PlayWithTypes
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1-->int \n2-->double \n3-->string");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int typeInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", typeInt + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double typeDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", typeDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string typeStr = Console.ReadLine();
                Console.WriteLine("Result: {0}", typeStr + "*");
                break;
        }
    }
}