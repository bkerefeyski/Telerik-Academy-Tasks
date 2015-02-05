using System;

class DeckOfCards
{
    static void Main()
    {
        //for (int i = 0; i < 13; i++)
        //{
            
        //        switch(i)
        //        {
        //            case 0: Console.WriteLine("2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds"); break;
        //            case 1: Console.WriteLine("3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds"); break;
        //            case 2: Console.WriteLine("4 of spades, 4 of clubs, 4 of hearts, 4 of diamonds"); break;
        //            case 3: Console.WriteLine("5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds"); break;
        //            case 4: Console.WriteLine("6 of spades, 6 of clubs, 6 of hearts, 6 of diamonds"); break;
        //            case 5: Console.WriteLine("7 of spades, 7 of clubs, 7 of hearts, 7 of diamonds"); break;
        //            case 6: Console.WriteLine("8 of spades, 8 of clubs, 8 of hearts, 8 of diamonds"); break;
        //            case 7: Console.WriteLine("9 of spades, 9 of clubs, 9 of hearts, 9 of diamonds"); break;
        //            case 8: Console.WriteLine("10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds"); break;
        //            case 9: Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds"); break;
        //            case 10: Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds"); break;
        //            case 11: Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds"); break;
        //            case 12: Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds"); break;

        //        }
        //}

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch(i)
                {
                    case 0: Console.Write("2 of "); break;
                    case 1: Console.Write("3 of "); break;
                    case 2: Console.Write("4 of "); break;
                    case 3: Console.Write("5 of "); break;
                    case 4: Console.Write("6 of "); break;
                    case 5: Console.Write("7 of "); break;
                    case 6: Console.Write("8 of "); break;
                    case 7: Console.Write("9 of "); break;
                    case 8: Console.Write("10 of "); break;
                    case 9: Console.Write("J of "); break;
                    case 10: Console.Write("Q of "); break;
                    case 11: Console.Write("K of "); break;
                    case 12: Console.Write("A of "); break;
                }
                if(j == 3)
                {
                    switch (j)
                    {
                        case 0: Console.Write("spades"); break;
                        case 1: Console.Write("clubs"); break;
                        case 2: Console.Write("hearts"); break;
                        case 3: Console.Write("diamonds"); break;

                    }
                }
                else
                { 
                    switch(j)
                    {
                        case 0: Console.Write("spades,"); break;
                        case 1: Console.Write("clubs, "); break;
                        case 2: Console.Write("hearts, "); break;
                        case 3: Console.Write("diamonds, "); break;

                    }
                }
                
            }
            Console.WriteLine();
        }

    }
}